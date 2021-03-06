﻿// NeuroRighter
// Copyright (c) 2008 John Rolston
//
// This file is part of NeuroRighter.
//
// NeuroRighter is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NeuroRighter is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with NeuroRighter.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NeuroRighter.DataTypes;
using System.Threading;
using ExtensionMethods;

namespace NeuroRighter.Server
{

    /// <summary>
    /// Data server for event-type data.
    /// </summary>
    public class EventDataSrv<T> where T : NREvent
    {
        /// <summary>
        /// Locking object to allow thread-safe read/write access to the data buffer.
        /// </summary>
        protected static readonly object lockObj = new object();

        // The 'New Data' Event Handler
        /// <summary>
        /// New data collected event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void NewDataHandler(object sender, NewEventDataEventArgs<T> e);

        // The 'NewData' Event
        /// <summary>
        /// New data collected event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public event NewDataHandler NewData;
        private NewEventDataEventArgs<T> eventArgs;

        // Main storage buffer
        private EventBuffer<T> dataBuffer;
        private EventBuffer<T> newDataBuffer; // holds newData Buffer when using multiple tasks

        private ulong[] currentSample;
        private ulong bufferSizeInSamples; // The maximum number of samples between thecurrent sample and the last available event time before it expires and is removed.
        private int numSamplesPerWrite;  // The number of samples for each buffer that events could have been detected in
        private ulong minCurrentSample;
        private ulong serverLagSamples;
        private double sampleFrequencyHz;
        private int channelCount;
        private int numUnits = 0;
        private Dictionary<int, int> unit2Channel;

        // Internal variables
        internal int numDataCollectionTasks; // number of daq data colleciton tasks

        /// <summary>
        /// Generic event-type data server (e.g. spikes). The main data buffer that this class updates
        /// 'dataBuffer', is itself a EventBuffer object. The  method ReadFromBuffer accepts a time range (in seconds referenced to the start of the recording)
        /// as input and will copy the portion of the current data buffer that is within that range to the user as a 
        /// EventBuffer object. The EstimateAvailableTimeRange method can be used to get an estimate of a valide range
        /// to enter for a Read operation. If there is no data in the time range provided, the method returns a null object.
        /// </summary>
        /// <param name="sampleFrequencyHz"> Sampling frequency of the DAQ that is feeding this server</param>
        /// <param name="bufferSizeSec">The requested history of the buffer in seconds</param>
        /// <param name="numSamplesPerWrite"> How many samples will the DAQ provide when a Write is called?</param>
        /// <param name="numDataCollectionTasks"> The number of external processes that can asynchronously add data to the buffer</param>
        /// <param name="serverLag"> If there is some lag in the process producing the samples, e.g. a filter like SALPA or spike detection, this is the total number of samples
        /// behind that this event process is compared to the raw process that produced it.</param>
        /// <param name="channelCount">The number of channels supplying this server </param>
        public EventDataSrv(double sampleFrequencyHz, double bufferSizeSec, int numSamplesPerWrite, int numDataCollectionTasks, int serverLag, int channelCount)
        {
            this.currentSample = new ulong[numDataCollectionTasks];
            this.minCurrentSample = 0;
            this.sampleFrequencyHz = sampleFrequencyHz;
            this.dataBuffer = new EventBuffer<T>(sampleFrequencyHz);
            this.newDataBuffer = new EventBuffer<T>(sampleFrequencyHz);
            this.numSamplesPerWrite = numSamplesPerWrite;
            this.bufferSizeInSamples = (ulong)Math.Ceiling(bufferSizeSec * sampleFrequencyHz);
            this.numDataCollectionTasks = numDataCollectionTasks;
            this.serverLagSamples = (ulong)serverLag;
            this.channelCount = channelCount;
        }

        /// <summary>
        /// Write data to the Event Server
        /// </summary>
        /// <param name="newData">An event buffer containing the events to add to the server</param>
        /// <param name="taskNo"> The NI task that created these new data</param>
        internal void WriteToBuffer(EventBuffer<T> newData, int taskNo)
        {
            lock (lockObj)
            {
                // First we must remove the expired samples (we cannot assume these are
                // in temporal order since for 64 channels, we have to write 2x, once for
                // each 32 channel recording task)
                if (minCurrentSample > bufferSizeInSamples)
                {
                    dataBuffer.Buffer.RemoveAll(x => x.SampleIndex < (minCurrentSample - (ulong)bufferSizeInSamples));
                }

                // Add new data to main buffer
                dataBuffer.Buffer.AddRange(newData.Buffer);

                // Update current read-head position
                currentSample[taskNo] += (ulong)numSamplesPerWrite;

                //The most up to date read position in the buffer is determined by the slowest input task
                if (serverLagSamples < currentSample.Min())
                    minCurrentSample = currentSample.Min() - serverLagSamples;
                else
                    minCurrentSample = 0;

                // Fire the new data event (only fire if the incoming buffer was not empty and somebody is listening)
                if (NewData != null)
                {
                    // Create space to sore new data
                    newDataBuffer.Buffer.AddRange(newData.Buffer);

                    if (taskNo == 0)
                    {
                        eventArgs = new NewEventDataEventArgs<T>(newDataBuffer);
                        NewData(this, eventArgs);
                        newDataBuffer.Buffer.Clear();
                    }
                }
            }
        }

        /// <summary>
        /// Write data to the Event Server. This write operation is used when the sampleIndicies in the newData buffer
        /// correspond to the start of a DAQ buffer poll rather than the start of the recording.
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="taskNo"></param>
        internal void WriteToBufferRelative(EventBuffer<T> newData, int taskNo)
        {
            lock (lockObj)
            {
                // First we must remove the expired samples (we cannot assume these are
                // in temporal order since for 64 channels, we have to write 2x, once for
                // each 32 channel recording task)
                if (minCurrentSample > bufferSizeInSamples)
                {
                    dataBuffer.Buffer.RemoveAll(x => x.SampleIndex < minCurrentSample - (ulong)bufferSizeInSamples);
                }

                // Move time stamps to absolute scheme
                for (int i = 0; i < newData.Buffer.Count; ++i)
                {
                    // Convert time stamps to absolute scheme
                    T tmp = (T)newData.Buffer[i].DeepClone();
                    tmp.SampleIndex = tmp.SampleIndex + currentSample[taskNo];
                    dataBuffer.Buffer.Add(tmp);

                    // Only add to the NewData buffer it is going to be cleared later
                    if (NewData != null)
                    {
                        newDataBuffer.Buffer.Add(tmp);
                    }
                }

                // Update current read-head position
                currentSample[taskNo] += (ulong)numSamplesPerWrite;
                if (serverLagSamples < currentSample.Min())
                    minCurrentSample = currentSample.Min() - serverLagSamples;
                else
                    minCurrentSample = 0;

                // Fire the new data event (only fire if the incoming buffer was not empty and somebody is listening)
                if (NewData != null && taskNo == 0)
                {
                    eventArgs = new NewEventDataEventArgs<T>(newDataBuffer);
                    NewData(this, eventArgs);
                    newDataBuffer.Buffer.Clear();
                }
            }
        }

        /// <summary>
        /// Sets the number of units handled by this channel
        /// </summary>
        /// <param name="numberOfUnits">The number of units detected by the spike sorter</param>
        internal void SetNumberOfUnits(int numberOfUnits)
        {
            numUnits = numberOfUnits;
        }

        internal void SetUnit2ChannelMap(Dictionary<int, int> u2C)
        {
            unit2Channel = u2C;
        }

        /// <summary>
        /// Estimate the avialable samples in the buffer. This can be used to inform
        /// the user of good arguments for the ReadFromBuffer method.
        /// </summary>
        /// <returns>timeRange</returns>
        public ulong[] EstimateAvailableTimeRange()
        {
            lock (lockObj)
            {
                ulong[] timeRange = new ulong[2];

                if (minCurrentSample < bufferSizeInSamples)
                    timeRange[0] = 0;
                else
                    timeRange[0] = (minCurrentSample - bufferSizeInSamples);

                timeRange[1] = minCurrentSample;

                return timeRange;
            }
        }

        /// <summary>
        /// Read data from buffer. This method will attempt to retrieve samples within the range
        /// specified by the input arguements. The object that is returned
        /// will contain information on the true sample bounds. You can use the EstimateAvailableTimeRange
        /// method to get a (time-sensitive) estimate for good-arguments for this method.
        /// </summary>
        /// <param name="desiredStartIndex">Earliest spike time-sample (inclusive), referenced to 0, that should be returned</param>
        /// <param name="desiredStopIndex">Latest spike time-sample (inclusive), referenced to 0, that should be returned</param>
        /// <returns>EventBuffer</returns>
        public EventBuffer<T> ReadFromBuffer(ulong desiredStartIndex, ulong desiredStopIndex)
        {
            lock (lockObj)
            {
                EventBuffer<T> returnBuffer = new EventBuffer<T>(sampleFrequencyHz);

                // Collect all the data within the desired sample range and add to the returnBuffer object
                //returnBuffer = dataBuffer.DeepClone();
                returnBuffer.Buffer.AddRange(
                    dataBuffer.Buffer.Where(
                        x => (x.SampleIndex >= desiredStartIndex
                        && x.SampleIndex <= desiredStopIndex)).ToList());

                // Return the data
                return returnBuffer;
            }
        }

        # region Public Accessors

        /// <summary>
        /// Sampling frequency for data collected for this server.
        /// </summary>
        public double SampleFrequencyHz
        {
            get
            {
                return sampleFrequencyHz;
            }
            set
            {
                sampleFrequencyHz = value;
            }
        }

        /// <summary>
        /// The number of channels supplying this server.
        /// </summary>
        public int ChannelCount
        {
            get
            {
                return channelCount;
            }
        }

        /// <summary>
        /// In the case that this is the spike server, this returns the number of detected units. If there is no spike sorting, this number is set to 0.
        /// </summary>
        public int NumUnits
        {
            get
            {
                return numUnits;
            }

        }

        /// <summary>
        /// In the case that this is the spike server, this returns the unit2channel mapping.
        /// </summary>
        public Dictionary<int, int> Unit2Channel
        {
            get
            {
                return unit2Channel;
            }

        }

        # endregion
    }
}
