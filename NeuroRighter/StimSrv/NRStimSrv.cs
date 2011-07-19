﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NeuroRighter.DataTypes;
using NeuroRighter.Output;
using NationalInstruments.DAQmx;
using System.Threading;
using System.Diagnostics;
using NeuroRighter.dbg;

namespace NeuroRighter.StimSrv
{
    /// <summary>
    /// NeuroRighter's stimulus server. Used in open and closed loop protocols for control over all output types.
    /// </summary>
    public class NRStimSrv
    {
        /// <summary>
        /// Aux analog output buffer.
        /// </summary>
        public AuxBuffer AuxOut;

        /// <summary>
        /// Aux digital output buffer.
        /// </summary>
        public DigitalBuffer DigitalOut;

        /// <summary>
        /// Electical stimulus (for use with NR's stimulator) output buffer.
        /// </summary>
        public StimBuffer StimOut;

        /// <summary>
        /// The DAC sampling frequency in Hz for all forms of output.
        /// </summary>
        public double sampleFrequencyHz;
        
        // Actual Tasks that play with NI DAQ
        internal Task buffLoadTask;
        internal ContStimTask stimTaskMaker;
        internal AuxOutTask auxTaskMaker;

        // Master timing and triggering task
        internal Task masterTask;
        private RealTimeDebugger debugger;

        private int INNERBUFFSIZE;
        private int STIM_SAMPLING_FREQ;
        private int buffloadcount;
        
        /// <summary>
        /// Neurorighter's stimulus/generic output server. Used in open-loop and closed-loop experiments where just-in-time buffering of output signals is required.
        /// </summary>
        /// <param name="INNERBUFFSIZE"> The size of one half of the double output buffer in samples</param>
        /// <param name="STIM_SAMPLING_FREQ">The DAC sampling frequency in Hz for all forms of output</param>
        /// <param name="masterTask">The NI Task to which all of the output clocks are synchronized to</param>
        /// <param name="debugger"> NR's real-time debugger</param>
        public NRStimSrv(int INNERBUFFSIZE, int STIM_SAMPLING_FREQ, Task masterTask, RealTimeDebugger debugger)
        {
            this.masterTask = masterTask;
            this.INNERBUFFSIZE = INNERBUFFSIZE;
            this.STIM_SAMPLING_FREQ = STIM_SAMPLING_FREQ;
            int sampblanking = 2;
            int queueThreshold = -1;//no queue thresholds for closed loop
            //create buffers
            AuxOut = new AuxBuffer(INNERBUFFSIZE, STIM_SAMPLING_FREQ, queueThreshold);
            DigitalOut = new DigitalBuffer(INNERBUFFSIZE, STIM_SAMPLING_FREQ, queueThreshold);
            StimOut = new StimBuffer(INNERBUFFSIZE, STIM_SAMPLING_FREQ, sampblanking, queueThreshold);
            this.debugger = debugger;
            buffloadcount = 0;
            this.sampleFrequencyHz = Convert.ToDouble(STIM_SAMPLING_FREQ);
            //basically, this needs to run, or at least start, the code for all the 'File2X' classes.
        }

        //this method writes the first 2 buffer loads to the daq in preparation
        internal void Setup()
        {
            ConfigureCounter();
            
            //assign tasks to buffers
            if (Properties.Settings.Default.UseAODO)
            {
                ConfigureAODO(true, masterTask);
                AuxOut.immortal = true;
                DigitalOut.immortal = true;
                DigitalOut.Setup(auxTaskMaker.digitalWriter, auxTaskMaker.digitalTask, buffLoadTask, debugger);
                AuxOut.Setup(auxTaskMaker.analogWriter, auxTaskMaker.analogTask, buffLoadTask, debugger);
                AuxOut.Start();
                
                DigitalOut.Start();
            }

            if (Properties.Settings.Default.UseStimulator)
            {
                ConfigureStim(masterTask);
                StimOut.immortal = true;
                StimOut.Setup(stimTaskMaker.analogWriter, stimTaskMaker.digitalWriter, stimTaskMaker.digitalTask, stimTaskMaker.analogTask, buffLoadTask, debugger);
                StimOut.Start();
            }
        }

        internal void StartAllTasks()
        {
            buffLoadTask.Start();
        }

        internal void StopAllBuffers()
        {
            if (AuxOut != null)
                AuxOut.Stop();
            if (DigitalOut != null)
                DigitalOut.Stop();
            if (StimOut != null)
                StimOut.Stop();
            Console.WriteLine("NRStimSrv: StimSrv output Buffers Stopped");
        }

        internal void KillAllAODOTasks()
        {
            
            if (buffLoadTask != null)
            {
                buffLoadTask.Stop();
                buffLoadTask.Dispose();
                buffLoadTask = null;
            } 
            Console.WriteLine("NRStimSrv: buffLoadTask is no more");
            lock(AuxOut)
                lock(DigitalOut)
                    if (auxTaskMaker != null)
                    {
                        auxTaskMaker.Dispose();
                        auxTaskMaker = null;
                    }
            Console.WriteLine("NRStimSrv: auxTasks are no more");
            lock(StimOut)
                if (stimTaskMaker != null)
                {
                    stimTaskMaker.Dispose();
                    stimTaskMaker = null;
                }
            Console.WriteLine("NRStimSrv: stimTasks are no more");

        }

        public int GetBuffSize()
        {
            return INNERBUFFSIZE;
        }

        private void ConfigureCounter()
        {
            //configure counter
            if (buffLoadTask != null) { buffLoadTask.Dispose(); buffLoadTask = null; }
            
            buffLoadTask = new Task("stimBufferTask");

            // Trigger a buffer load event off every edge of this channel
            buffLoadTask.COChannels.CreatePulseChannelFrequency(Properties.Settings.Default.SigOutDev + "/ctr1",
                "BufferLoadCounter", COPulseFrequencyUnits.Hertz, COPulseIdleState.Low, 0, ((double)STIM_SAMPLING_FREQ / (double)INNERBUFFSIZE) / 2.0, 0.5);
            buffLoadTask.Timing.ConfigureImplicit(SampleQuantityMode.ContinuousSamples);
            buffLoadTask.SynchronizeCallbacks = false;
            buffLoadTask.Timing.ReferenceClockSource = "OnboardClock";
            buffLoadTask.Control(TaskAction.Verify);

            // Syncronize the start to the master recording task
            buffLoadTask.Triggers.ArmStartTrigger.ConfigureDigitalEdgeTrigger(
                masterTask.Triggers.StartTrigger.Terminal, DigitalEdgeArmStartTriggerEdge.Rising);
            buffLoadTask.CounterOutput += new CounterOutputEventHandler(delegate
                {
                    Thread thrd = Thread.CurrentThread;
                    thrd.Priority = ThreadPriority.Highest;
                    debugger.Write("output counter tick " +buffloadcount.ToString());
                    buffloadcount++;
                }
            );
        }

        private void ConfigureStim(Task masterTask)
        {

            //configure stim
            // Refresh DAQ tasks as they are needed for file2stim
            if (stimTaskMaker != null)
            {
                stimTaskMaker.Dispose();
                stimTaskMaker = null;
            }

            // Create new DAQ tasks and corresponding writers
            stimTaskMaker = new ContStimTask(Properties.Settings.Default.StimulatorDevice,
                INNERBUFFSIZE);
            stimTaskMaker.MakeAODOTasks("NeuralStim",
                Properties.Settings.Default.StimPortBandwidth,
                STIM_SAMPLING_FREQ);

            // Verify
            stimTaskMaker.VerifyTasks();

            // Sync DO start to AO start
            stimTaskMaker.SyncDOStartToAOStart();

            // Syncronize stimulation with the master task
            stimTaskMaker.SyncTasksToMasterClock(masterTask);
            stimTaskMaker.SyncTasksToMasterStart(masterTask);

            // Create buffer writters
            stimTaskMaker.MakeWriters();

            // Verify
            stimTaskMaker.VerifyTasks();
        }

        private void ConfigureAODO(bool digProvided, Task masterTask)
        {
            //configure stim
            // Refresh DAQ tasks as they are needed for file2stim
            if (auxTaskMaker != null)
            {
                auxTaskMaker.Dispose();
                auxTaskMaker = null;
            }

            // Create new DAQ tasks and corresponding writers
            auxTaskMaker = new AuxOutTask(Properties.Settings.Default.SigOutDev,
                INNERBUFFSIZE);
            auxTaskMaker.MakeAODOTasks("auxOut",
                STIM_SAMPLING_FREQ,
                digProvided);

            // Verify
            auxTaskMaker.VerifyTasks();

            // Sync DO start to AO start
            if (digProvided)
                auxTaskMaker.SyncDOStartToAOStart();

            // Syncronize stimulation with the master task
            auxTaskMaker.SyncTasksToMasterClock(masterTask);
            auxTaskMaker.SyncTasksToMasterStart(masterTask);

            // Create buffer writters
            auxTaskMaker.MakeWriters();

            // Verify
            auxTaskMaker.VerifyTasks();
        }

       



    }
}
