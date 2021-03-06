namespace NeuroRighter
{
    partial class NeuroRighter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuroRighter));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.led_recording = new NationalInstruments.UI.WindowsForms.Led();
            this.label8 = new System.Windows.Forms.Label();
            this.switch_record = new NationalInstruments.UI.WindowsForms.Switch();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.checkbox_repeatRecord = new System.Windows.Forms.CheckBox();
            this.numericUpDown_timedRecordingDurationSeconds = new System.Windows.Forms.NumericUpDown();
            this.checkBox_RetrainOnRestart = new System.Windows.Forms.CheckBox();
            this.label90 = new System.Windows.Forms.Label();
            this.checkBox_enableTimedRecording = new System.Windows.Forms.CheckBox();
            this.numericUpDown_timedRecordingDuration = new System.Windows.Forms.NumericUpDown();
            this.label72 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.button_SetRecordingStreams = new System.Windows.Forms.Button();
            this.button_BrowseOutputFile = new System.Windows.Forms.Button();
            this.textBox_OutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EnterNote = new System.Windows.Forms.Button();
            this.checkBox_video = new System.Windows.Forms.CheckBox();
            this.label_timeElapsed = new System.Windows.Forms.Label();
            this.toolTip_outputFilename = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_SALPA = new System.Windows.Forms.CheckBox();
            this.checkBox_freeze = new System.Windows.Forms.CheckBox();
            this.button_scaleReset = new System.Windows.Forms.Button();
            this.button_scaleDown = new System.Windows.Forms.Button();
            this.button_scaleUp = new System.Windows.Forms.Button();
            this.checkBox_spikesFilter = new System.Windows.Forms.CheckBox();
            this.checkBox_artiFilt = new System.Windows.Forms.CheckBox();
            this.checkBox_LFPsFilter = new System.Windows.Forms.CheckBox();
            this.button_Train = new System.Windows.Forms.Button();
            this.checkBox_MUAFilter = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button_TrainSpkDet = new System.Windows.Forms.Button();
            this.button_OpenSpkDetSettings = new System.Windows.Forms.Button();
            this.groupBox_SALPA = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_noise = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_salpa_asym = new System.Windows.Forms.NumericUpDown();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.numericUpDown_salpa_ahead = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_forcepeg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_postpeg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salpa_halfwidth = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.SpikeFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SpikeHighCut = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SpikeLowCut = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_expt = new System.Windows.Forms.Timer(this.components);
            this.bw_genExpt = new System.ComponentModel.BackgroundWorker();
            this.bw_stim = new System.ComponentModel.BackgroundWorker();
            this.bw_openLoop = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DisplaySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documenationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeAPIReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeRespositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedloopExampleCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_sidebar = new System.Windows.Forms.TabControl();
            this.tabPage_SpikeFilters = new System.Windows.Forms.TabPage();
            this.tabPage_OtherFilters = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.EEGFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.EEGHighCut = new System.Windows.Forms.NumericUpDown();
            this.EEGLowCut = new System.Windows.Forms.NumericUpDown();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_MUAFilterOrder = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MUAHighCut = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.LFPFiltOrder = new System.Windows.Forms.NumericUpDown();
            this.LFPHighCut = new System.Windows.Forms.NumericUpDown();
            this.LFPLowCut = new System.Windows.Forms.NumericUpDown();
            this.tabPage_MiscSettings = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.channelOut = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.spkWfmPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.timer_timeElapsed = new System.Windows.Forms.Timer(this.components);
            this.imageList_zoomButtons = new System.Windows.Forms.ImageList(this.components);
            this.NRPersistWindowComponent = new Mowog.PersistWindowComponent(this.components);
            this.tabPage_ProgRef = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_digRefSpikes = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBox_digRefSpikes = new System.Windows.Forms.CheckBox();
            this.numericUpDown_digRefLFPs = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.checkBox_digRefLFPs = new System.Windows.Forms.CheckBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.radioButton_spikeReferencingNone = new System.Windows.Forms.RadioButton();
            this.radioButton_spikesReferencingCommonMedianLocal = new System.Windows.Forms.RadioButton();
            this.radioButton_spikesReferencingCommonMedian = new System.Windows.Forms.RadioButton();
            this.radioButton_spikesReferencingCommonAverage = new System.Windows.Forms.RadioButton();
            this.label83 = new System.Windows.Forms.Label();
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup = new System.Windows.Forms.NumericUpDown();
            this.groupBox_plexonProgRef = new System.Windows.Forms.GroupBox();
            this.numericUpDown_analogRefSpikes = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.checkBox_analogRefSpikes = new System.Windows.Forms.CheckBox();
            this.numericUpDown_analogRefLFPs = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.checkBox_analogRefLFPs = new System.Windows.Forms.CheckBox();
            this.button_analogResetRefs = new System.Windows.Forms.Button();
            this.tabPage_impedance = new System.Windows.Forms.TabPage();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.button_impedanceCopyDataToClipboard = new System.Windows.Forms.Button();
            this.button_impedanceCancel = new System.Windows.Forms.Button();
            this.button_impedanceTest = new System.Windows.Forms.Button();
            this.progressBar_impedance = new System.Windows.Forms.ProgressBar();
            this.button_impedanceSaveAsMAT = new System.Windows.Forms.Button();
            this.label_impedanceProgress = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.radioButton_impCurrent = new System.Windows.Forms.RadioButton();
            this.radioButton_impVoltage = new System.Windows.Forms.RadioButton();
            this.numericUpDown_RCurr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RGain = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RMeas = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDown_impCommandVoltage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_impStopFreq = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.numericUpDown_impStartFreq = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown_impNumPeriods = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.checkBox_impBandpassFilter = new System.Windows.Forms.CheckBox();
            this.checkBox_impUseMatchedFilter = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox_impedanceResults = new System.Windows.Forms.TextBox();
            this.scatterGraph_impedance = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.scatterPlot2 = new NationalInstruments.UI.ScatterPlot();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_impChannel = new System.Windows.Forms.NumericUpDown();
            this.checkBox_impedanceAllChannels = new System.Windows.Forms.CheckBox();
            this.tabPage_stim = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_stim = new System.Windows.Forms.Button();
            this.stimPulses = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.stimVoltage = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.stimRate = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.stimWidth = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.stimChannel = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.stimInterphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.radioButton_OnDemandUniphasic = new System.Windows.Forms.RadioButton();
            this.radioButton_OnDemandBiphasic = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_stimExpt = new System.Windows.Forms.Button();
            this.progressBar_stimExpt = new System.Windows.Forms.ProgressBar();
            this.listBox_exptStimChannels = new System.Windows.Forms.ListBox();
            this.button_stopExpt = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_exptVoltages = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox_exptPPT = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox_exptPulseWidths = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.numericUpDown_exptNumRepeats = new System.Windows.Forms.NumericUpDown();
            this.button_ElectrodeScreeningSelectAll = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.button_ElectrodeScreeningSelectNone = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.openLoopRate = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.openLoopVoltage1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.openLoopWidth1 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.openLoopStart = new System.Windows.Forms.Button();
            this.openLoopStop = new System.Windows.Forms.Button();
            this.listBox_stimChannels = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.openLoopInterphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.openLoopVoltage2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.openLoopWidth2 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.openLoopPrephaseLength = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.openLoopPostphaseLength = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.button_openLoopSelectAll = new System.Windows.Forms.Button();
            this.button_openLoopSelectNone = new System.Windows.Forms.Button();
            this.waveformGraph_openLoopStimPulse = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.button_electrolesioningStart = new System.Windows.Forms.Button();
            this.numericUpDown_electrolesioningVoltage = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.numericUpDown_electrolesioningDuration = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.listBox_electrolesioningChannels = new System.Windows.Forms.ListBox();
            this.button_electrolesioningSelectAll = new System.Windows.Forms.Button();
            this.button_electrolesioningSelectNone = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_IISZapper_pulsePerTrain = new System.Windows.Forms.NumericUpDown();
            this.label70 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_voltage = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_rate = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_phaseWidth = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.numericUpDown_IISZapper_channel = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.button_IISZapper_start = new System.Windows.Forms.Button();
            this.button_IISZapper_stop = new System.Windows.Forms.Button();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.offsetVoltage = new System.Windows.Forms.NumericUpDown();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.radioButton_stimCurrentControlled = new System.Windows.Forms.RadioButton();
            this.radioButton_stimVoltageControlled = new System.Windows.Forms.RadioButton();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.button_startStimFromFile = new System.Windows.Forms.Button();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox_protocolFileLocations = new System.Windows.Forms.TextBox();
            this.button_stopStimFromFile = new System.Windows.Forms.Button();
            this.button_BrowseOLStimFile = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox_digitalProtocolFileLocation = new System.Windows.Forms.TextBox();
            this.button_BrowseOLDFile = new System.Windows.Forms.Button();
            this.checkBox_useManStimWaveform = new System.Windows.Forms.CheckBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox_AuxFile = new System.Windows.Forms.TextBox();
            this.button_browseAuxFile = new System.Windows.Forms.Button();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.checkBox_RepeatOpenLoopProtocol = new System.Windows.Forms.CheckBox();
            this.numericUpDown_NumberOfOpenLoopRepeats = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.button_startClosedLoopStim = new System.Windows.Forms.Button();
            this.textBox_ClosedLoopProtocolFile = new System.Windows.Forms.TextBox();
            this.button_stopClosedLoopStim = new System.Windows.Forms.Button();
            this.button_browseCLStimFiles = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_useManStimWaveformCL = new System.Windows.Forms.CheckBox();
            this.label63 = new System.Windows.Forms.Label();
            this.comboBox_closedLoopProtocol = new System.Windows.Forms.ComboBox();
            this.tabPage_EEG = new System.Windows.Forms.TabPage();
            this.tabPage_MUA = new System.Windows.Forms.TabPage();
            this.tabPage_LFPs = new System.Windows.Forms.TabPage();
            this.tabPage_AuxInput = new System.Windows.Forms.TabPage();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.scatterGraph_AuxAnalogData = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.yAxis5 = new NationalInstruments.UI.YAxis();
            this.xAxis5 = new NationalInstruments.UI.XAxis();
            this.scatterPlot3 = new NationalInstruments.UI.ScatterPlot();
            this.slide_AnalogDispMaxVoltage = new NationalInstruments.UI.WindowsForms.Slide();
            this.slide_AnalogDispWidth = new NationalInstruments.UI.WindowsForms.Slide();
            this.checkBox_FreezeAuxPlot = new System.Windows.Forms.CheckBox();
            this.slide_AuxShift = new NationalInstruments.UI.WindowsForms.Slide();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.ledArray_DigitalState = new NationalInstruments.UI.WindowsForms.LedArray();
            this.tabPage_waveforms = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown_NumSnipsDisplayed = new System.Windows.Forms.NumericUpDown();
            this.button_clearSpkWfms = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_spikes = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.button_computeGain = new System.Windows.Forms.Button();
            this.numericUpDown_stopFreq = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_startFreq = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.numericUpDown_diagnosticsVoltage = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDown_numPeriods = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox_diagnosticsBulk = new System.Windows.Forms.CheckBox();
            this.checkBox_diagnosticsVotlageDivider = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.scatterGraph_diagnostics = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.scatterPlot1 = new NationalInstruments.UI.ScatterPlot();
            this.textBox_diagnosticsResults = new System.Windows.Forms.TextBox();
            this.textBox_voltageDivider = new System.Windows.Forms.TextBox();
            this.textBox_diagnosticsMult = new System.Windows.Forms.TextBox();
            this.checkBox_diagnosticsDigitalFilter = new System.Windows.Forms.CheckBox();
            this.tabPage_diagnostics = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_recording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_record)).BeginInit();
            this.groupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDurationSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDuration)).BeginInit();
            this.groupBox27.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox_SALPA.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_asym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_ahead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_forcepeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_halfwidth)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeLowCut)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_sidebar.SuspendLayout();
            this.tabPage_SpikeFilters.SuspendLayout();
            this.tabPage_OtherFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EEGFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGLowCut)).BeginInit();
            this.groupBox36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MUAFilterOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MUAHighCut)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFPFiltOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPHighCut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPLowCut)).BeginInit();
            this.tabPage_MiscSettings.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelOut)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.tabPage_ProgRef.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefSpikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefLFPs)).BeginInit();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup)).BeginInit();
            this.groupBox_plexonProgRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefSpikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefLFPs)).BeginInit();
            this.tabPage_impedance.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RCurr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impCommandVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impNumPeriods)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_impedance)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impChannel)).BeginInit();
            this.tabPage_stim.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimPulses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimInterphaseLength)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exptNumRepeats)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopInterphaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPrephaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPostphaseLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_openLoopStimPulse)).BeginInit();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningDuration)).BeginInit();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_pulsePerTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_phaseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_channel)).BeginInit();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetVoltage)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfOpenLoopRepeats)).BeginInit();
            this.groupBox35.SuspendLayout();
            this.tabPage_AuxInput.SuspendLayout();
            this.groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_AuxAnalogData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AnalogDispMaxVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AnalogDispWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AuxShift)).BeginInit();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledArray_DigitalState.ItemTemplate)).BeginInit();
            this.tabPage_waveforms.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumSnipsDisplayed)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diagnosticsVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_diagnostics)).BeginInit();
            this.tabPage_diagnostics.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(139, 785);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(51, 34);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(193, 785);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(51, 34);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.led_recording);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.switch_record);
            this.groupBox1.Controls.Add(this.groupBox32);
            this.groupBox1.Controls.Add(this.groupBox27);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(4, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording";
            // 
            // led_recording
            // 
            this.led_recording.LedStyle = NationalInstruments.UI.LedStyle.Square;
            this.led_recording.Location = new System.Drawing.Point(206, 62);
            this.led_recording.Name = "led_recording";
            this.led_recording.OffColor = System.Drawing.Color.LimeGreen;
            this.led_recording.Size = new System.Drawing.Size(35, 35);
            this.led_recording.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Write to file?";
            // 
            // switch_record
            // 
            this.switch_record.Location = new System.Drawing.Point(169, 41);
            this.switch_record.Name = "switch_record";
            this.switch_record.Size = new System.Drawing.Size(39, 66);
            this.switch_record.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch_record.TabIndex = 29;
            this.switch_record.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch_record_StateChanged);
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.checkbox_repeatRecord);
            this.groupBox32.Controls.Add(this.numericUpDown_timedRecordingDurationSeconds);
            this.groupBox32.Controls.Add(this.checkBox_RetrainOnRestart);
            this.groupBox32.Controls.Add(this.label90);
            this.groupBox32.Controls.Add(this.checkBox_enableTimedRecording);
            this.groupBox32.Controls.Add(this.numericUpDown_timedRecordingDuration);
            this.groupBox32.Controls.Add(this.label72);
            this.groupBox32.Controls.Add(this.label89);
            this.groupBox32.Location = new System.Drawing.Point(6, 120);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(242, 102);
            this.groupBox32.TabIndex = 39;
            this.groupBox32.TabStop = false;
            // 
            // checkbox_repeatRecord
            // 
            this.checkbox_repeatRecord.AutoSize = true;
            this.checkbox_repeatRecord.Enabled = false;
            this.checkbox_repeatRecord.Location = new System.Drawing.Point(9, 53);
            this.checkbox_repeatRecord.Name = "checkbox_repeatRecord";
            this.checkbox_repeatRecord.Size = new System.Drawing.Size(145, 17);
            this.checkbox_repeatRecord.TabIndex = 41;
            this.checkbox_repeatRecord.Text = "Repeat Timed Recording";
            this.checkbox_repeatRecord.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_timedRecordingDurationSeconds
            // 
            this.numericUpDown_timedRecordingDurationSeconds.Enabled = false;
            this.numericUpDown_timedRecordingDurationSeconds.Location = new System.Drawing.Point(149, 24);
            this.numericUpDown_timedRecordingDurationSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_timedRecordingDurationSeconds.Name = "numericUpDown_timedRecordingDurationSeconds";
            this.numericUpDown_timedRecordingDurationSeconds.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_timedRecordingDurationSeconds.TabIndex = 36;
            // 
            // checkBox_RetrainOnRestart
            // 
            this.checkBox_RetrainOnRestart.AutoSize = true;
            this.checkBox_RetrainOnRestart.Location = new System.Drawing.Point(9, 76);
            this.checkBox_RetrainOnRestart.Name = "checkBox_RetrainOnRestart";
            this.checkBox_RetrainOnRestart.Size = new System.Drawing.Size(156, 17);
            this.checkBox_RetrainOnRestart.TabIndex = 42;
            this.checkBox_RetrainOnRestart.Text = "Retrain Detector on Restart";
            this.checkBox_RetrainOnRestart.UseVisualStyleBackColor = true;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(201, 29);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(26, 13);
            this.label90.TabIndex = 38;
            this.label90.Text = "Sec";
            // 
            // checkBox_enableTimedRecording
            // 
            this.checkBox_enableTimedRecording.AutoSize = true;
            this.checkBox_enableTimedRecording.Location = new System.Drawing.Point(9, -1);
            this.checkBox_enableTimedRecording.Name = "checkBox_enableTimedRecording";
            this.checkBox_enableTimedRecording.Size = new System.Drawing.Size(143, 17);
            this.checkBox_enableTimedRecording.TabIndex = 34;
            this.checkBox_enableTimedRecording.Text = "Enable Timed Recording";
            this.checkBox_enableTimedRecording.UseVisualStyleBackColor = true;
            this.checkBox_enableTimedRecording.CheckedChanged += new System.EventHandler(this.checkBox_enableTimedRecording_CheckedChanged);
            // 
            // numericUpDown_timedRecordingDuration
            // 
            this.numericUpDown_timedRecordingDuration.Enabled = false;
            this.numericUpDown_timedRecordingDuration.Location = new System.Drawing.Point(65, 24);
            this.numericUpDown_timedRecordingDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_timedRecordingDuration.Name = "numericUpDown_timedRecordingDuration";
            this.numericUpDown_timedRecordingDuration.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_timedRecordingDuration.TabIndex = 33;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(3, 28);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(59, 13);
            this.label72.TabIndex = 35;
            this.label72.Text = "Rec. Time:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(116, 29);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(24, 13);
            this.label89.TabIndex = 37;
            this.label89.Text = "Min";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.button_SetRecordingStreams);
            this.groupBox27.Controls.Add(this.button_BrowseOutputFile);
            this.groupBox27.Controls.Add(this.textBox_OutputFile);
            this.groupBox27.Controls.Add(this.label1);
            this.groupBox27.Location = new System.Drawing.Point(6, 19);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(242, 95);
            this.groupBox27.TabIndex = 44;
            this.groupBox27.TabStop = false;
            // 
            // button_SetRecordingStreams
            // 
            this.button_SetRecordingStreams.Location = new System.Drawing.Point(10, 55);
            this.button_SetRecordingStreams.Name = "button_SetRecordingStreams";
            this.button_SetRecordingStreams.Size = new System.Drawing.Size(147, 23);
            this.button_SetRecordingStreams.TabIndex = 43;
            this.button_SetRecordingStreams.Text = "Set Recording Streams";
            this.button_SetRecordingStreams.UseVisualStyleBackColor = true;
            this.button_SetRecordingStreams.Click += new System.EventHandler(this.button_SetRecordingStreams_Click);
            // 
            // button_BrowseOutputFile
            // 
            this.button_BrowseOutputFile.Location = new System.Drawing.Point(132, 19);
            this.button_BrowseOutputFile.Name = "button_BrowseOutputFile";
            this.button_BrowseOutputFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOutputFile.TabIndex = 28;
            this.button_BrowseOutputFile.Text = "...";
            this.button_BrowseOutputFile.UseVisualStyleBackColor = true;
            this.button_BrowseOutputFile.Click += new System.EventHandler(this.button_BrowseOutputFile_Click);
            // 
            // textBox_OutputFile
            // 
            this.textBox_OutputFile.Location = new System.Drawing.Point(10, 21);
            this.textBox_OutputFile.Name = "textBox_OutputFile";
            this.textBox_OutputFile.ReadOnly = true;
            this.textBox_OutputFile.Size = new System.Drawing.Size(116, 20);
            this.textBox_OutputFile.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Setup";
            // 
            // button_EnterNote
            // 
            this.button_EnterNote.BackColor = System.Drawing.Color.Yellow;
            this.button_EnterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EnterNote.ForeColor = System.Drawing.Color.Black;
            this.button_EnterNote.Location = new System.Drawing.Point(85, 785);
            this.button_EnterNote.Name = "button_EnterNote";
            this.button_EnterNote.Size = new System.Drawing.Size(51, 34);
            this.button_EnterNote.TabIndex = 33;
            this.button_EnterNote.Text = "Note";
            this.button_EnterNote.UseVisualStyleBackColor = false;
            this.button_EnterNote.Click += new System.EventHandler(this.button_EnterNote_Click);
            // 
            // checkBox_video
            // 
            this.checkBox_video.AutoSize = true;
            this.checkBox_video.Location = new System.Drawing.Point(9, 19);
            this.checkBox_video.Name = "checkBox_video";
            this.checkBox_video.Size = new System.Drawing.Size(91, 17);
            this.checkBox_video.TabIndex = 31;
            this.checkBox_video.Text = "Record Video";
            this.checkBox_video.UseVisualStyleBackColor = true;
            // 
            // label_timeElapsed
            // 
            this.label_timeElapsed.AutoSize = true;
            this.label_timeElapsed.ForeColor = System.Drawing.Color.DimGray;
            this.label_timeElapsed.Location = new System.Drawing.Point(7, 789);
            this.label_timeElapsed.Name = "label_timeElapsed";
            this.label_timeElapsed.Size = new System.Drawing.Size(74, 26);
            this.label_timeElapsed.TabIndex = 32;
            this.label_timeElapsed.Text = "Time Elapsed:\r\n00:00:00";
            this.label_timeElapsed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox_SALPA
            // 
            this.checkBox_SALPA.AutoSize = true;
            this.checkBox_SALPA.BackColor = System.Drawing.Color.White;
            this.checkBox_SALPA.Enabled = false;
            this.checkBox_SALPA.Location = new System.Drawing.Point(6, 0);
            this.checkBox_SALPA.Name = "checkBox_SALPA";
            this.checkBox_SALPA.Size = new System.Drawing.Size(60, 17);
            this.checkBox_SALPA.TabIndex = 13;
            this.checkBox_SALPA.Text = "SALPA";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_SALPA, resources.GetString("checkBox_SALPA.ToolTip"));
            this.checkBox_SALPA.UseVisualStyleBackColor = false;
            this.checkBox_SALPA.CheckedChanged += new System.EventHandler(this.checkBox_SALPA_CheckedChanged);
            // 
            // checkBox_freeze
            // 
            this.checkBox_freeze.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_freeze.AutoSize = true;
            this.checkBox_freeze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_freeze.Location = new System.Drawing.Point(165, 29);
            this.checkBox_freeze.Name = "checkBox_freeze";
            this.checkBox_freeze.Size = new System.Drawing.Size(75, 23);
            this.checkBox_freeze.TabIndex = 12;
            this.checkBox_freeze.Text = "Freeze Plots";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_freeze, "Freeze display");
            this.checkBox_freeze.UseVisualStyleBackColor = true;
            // 
            // button_scaleReset
            // 
            this.button_scaleReset.Enabled = false;
            this.button_scaleReset.FlatAppearance.BorderSize = 0;
            this.button_scaleReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleReset.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleReset.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleReset.Image")));
            this.button_scaleReset.Location = new System.Drawing.Point(103, 24);
            this.button_scaleReset.Name = "button_scaleReset";
            this.button_scaleReset.Size = new System.Drawing.Size(40, 40);
            this.button_scaleReset.TabIndex = 11;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleReset, "Reset display gain");
            this.button_scaleReset.UseVisualStyleBackColor = true;
            this.button_scaleReset.Click += new System.EventHandler(this.button_scaleReset_Click);
            this.button_scaleReset.MouseEnter += new System.EventHandler(this.button_scaleReset_MouseEnter);
            this.button_scaleReset.MouseLeave += new System.EventHandler(this.button_scaleReset_MouseLeave);
            // 
            // button_scaleDown
            // 
            this.button_scaleDown.Enabled = false;
            this.button_scaleDown.FlatAppearance.BorderSize = 0;
            this.button_scaleDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleDown.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleDown.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleDown.Image")));
            this.button_scaleDown.Location = new System.Drawing.Point(60, 24);
            this.button_scaleDown.Name = "button_scaleDown";
            this.button_scaleDown.Size = new System.Drawing.Size(40, 40);
            this.button_scaleDown.TabIndex = 9;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleDown, "Decrease display gain");
            this.button_scaleDown.UseVisualStyleBackColor = true;
            this.button_scaleDown.Click += new System.EventHandler(this.button_scaleDown_Click);
            this.button_scaleDown.MouseEnter += new System.EventHandler(this.button_scaleDown_MouseEnter);
            this.button_scaleDown.MouseLeave += new System.EventHandler(this.button_scaleDown_MouseLeave);
            // 
            // button_scaleUp
            // 
            this.button_scaleUp.Enabled = false;
            this.button_scaleUp.FlatAppearance.BorderSize = 0;
            this.button_scaleUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scaleUp.ForeColor = System.Drawing.Color.Transparent;
            this.button_scaleUp.Image = ((System.Drawing.Image)(resources.GetObject("button_scaleUp.Image")));
            this.button_scaleUp.Location = new System.Drawing.Point(17, 24);
            this.button_scaleUp.Name = "button_scaleUp";
            this.button_scaleUp.Size = new System.Drawing.Size(40, 40);
            this.button_scaleUp.TabIndex = 10;
            this.toolTip_outputFilename.SetToolTip(this.button_scaleUp, "Increase display gain");
            this.button_scaleUp.UseVisualStyleBackColor = true;
            this.button_scaleUp.Click += new System.EventHandler(this.button_scaleUp_Click);
            this.button_scaleUp.MouseEnter += new System.EventHandler(this.button_scaleUp_MouseEnter);
            this.button_scaleUp.MouseLeave += new System.EventHandler(this.button_scaleUp_MouseLeave);
            // 
            // checkBox_spikesFilter
            // 
            this.checkBox_spikesFilter.AutoSize = true;
            this.checkBox_spikesFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_spikesFilter.Checked = true;
            this.checkBox_spikesFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_spikesFilter.Location = new System.Drawing.Point(9, 0);
            this.checkBox_spikesFilter.Name = "checkBox_spikesFilter";
            this.checkBox_spikesFilter.Size = new System.Drawing.Size(79, 17);
            this.checkBox_spikesFilter.TabIndex = 14;
            this.checkBox_spikesFilter.Text = "Spike Pass";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_spikesFilter, "Butterworth band-pass filter of arbitrary order to\r\nfocus on a particular spike p" +
        "ass-band.");
            this.checkBox_spikesFilter.UseVisualStyleBackColor = false;
            this.checkBox_spikesFilter.CheckedChanged += new System.EventHandler(this.checkBox_spikesFilter_CheckedChanged);
            // 
            // checkBox_artiFilt
            // 
            this.checkBox_artiFilt.AutoSize = true;
            this.checkBox_artiFilt.Enabled = false;
            this.checkBox_artiFilt.Location = new System.Drawing.Point(17, 108);
            this.checkBox_artiFilt.Name = "checkBox_artiFilt";
            this.checkBox_artiFilt.Size = new System.Drawing.Size(97, 17);
            this.checkBox_artiFilt.TabIndex = 14;
            this.checkBox_artiFilt.Text = "Engage ArtiFilt ";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_artiFilt, "Template subtraction based artifact removal of LFP \r\nartifacts.");
            this.checkBox_artiFilt.UseVisualStyleBackColor = true;
            // 
            // checkBox_LFPsFilter
            // 
            this.checkBox_LFPsFilter.AutoSize = true;
            this.checkBox_LFPsFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_LFPsFilter.Checked = true;
            this.checkBox_LFPsFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_LFPsFilter.Location = new System.Drawing.Point(9, 0);
            this.checkBox_LFPsFilter.Name = "checkBox_LFPsFilter";
            this.checkBox_LFPsFilter.Size = new System.Drawing.Size(71, 17);
            this.checkBox_LFPsFilter.TabIndex = 18;
            this.checkBox_LFPsFilter.Text = "LFP Pass";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_LFPsFilter, "Butterworth band-pass filter of arbitrary order to\r\nfocus on the LFP pass-band.");
            this.checkBox_LFPsFilter.UseVisualStyleBackColor = false;
            // 
            // button_Train
            // 
            this.button_Train.Location = new System.Drawing.Point(6, 19);
            this.button_Train.Name = "button_Train";
            this.button_Train.Size = new System.Drawing.Size(208, 23);
            this.button_Train.TabIndex = 4;
            this.button_Train.Text = "Train";
            this.toolTip_outputFilename.SetToolTip(this.button_Train, "Store channel noise levels. This is needed to use SALPA.");
            this.button_Train.UseVisualStyleBackColor = true;
            this.button_Train.Click += new System.EventHandler(this.button_Train_Click);
            // 
            // checkBox_MUAFilter
            // 
            this.checkBox_MUAFilter.AutoSize = true;
            this.checkBox_MUAFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_MUAFilter.Checked = true;
            this.checkBox_MUAFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MUAFilter.Location = new System.Drawing.Point(9, 0);
            this.checkBox_MUAFilter.Name = "checkBox_MUAFilter";
            this.checkBox_MUAFilter.Size = new System.Drawing.Size(76, 17);
            this.checkBox_MUAFilter.TabIndex = 18;
            this.checkBox_MUAFilter.Text = "MUA Pass";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_MUAFilter, "Butterworth band-pass filter of arbitrary order to\r\nfocus on the LFP pass-band.");
            this.checkBox_MUAFilter.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(9, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "EEG Pass";
            this.toolTip_outputFilename.SetToolTip(this.checkBox2, "Butterworth band-pass filter of arbitrary order to\r\nfocus on the LFP pass-band.");
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox_SALPA);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 426);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button_TrainSpkDet);
            this.groupBox8.Controls.Add(this.button_OpenSpkDetSettings);
            this.groupBox8.Location = new System.Drawing.Point(5, 369);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(231, 51);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spike Detection";
            // 
            // button_TrainSpkDet
            // 
            this.button_TrainSpkDet.Location = new System.Drawing.Point(119, 19);
            this.button_TrainSpkDet.Name = "button_TrainSpkDet";
            this.button_TrainSpkDet.Size = new System.Drawing.Size(107, 23);
            this.button_TrainSpkDet.TabIndex = 1;
            this.button_TrainSpkDet.Text = "Retrain";
            this.button_TrainSpkDet.UseVisualStyleBackColor = true;
            this.button_TrainSpkDet.Click += new System.EventHandler(this.button_TrainSpkDet_Click);
            // 
            // button_OpenSpkDetSettings
            // 
            this.button_OpenSpkDetSettings.Location = new System.Drawing.Point(6, 19);
            this.button_OpenSpkDetSettings.Name = "button_OpenSpkDetSettings";
            this.button_OpenSpkDetSettings.Size = new System.Drawing.Size(107, 23);
            this.button_OpenSpkDetSettings.TabIndex = 0;
            this.button_OpenSpkDetSettings.Text = "Edit Settings";
            this.button_OpenSpkDetSettings.UseVisualStyleBackColor = true;
            this.button_OpenSpkDetSettings.Click += new System.EventHandler(this.button_OpenSpkDetSettings_Click);
            // 
            // groupBox_SALPA
            // 
            this.groupBox_SALPA.Controls.Add(this.groupBox7);
            this.groupBox_SALPA.Controls.Add(this.label10);
            this.groupBox_SALPA.Controls.Add(this.numericUpDown_salpa_asym);
            this.groupBox_SALPA.Controls.Add(this.label86);
            this.groupBox_SALPA.Controls.Add(this.label87);
            this.groupBox_SALPA.Controls.Add(this.label84);
            this.groupBox_SALPA.Controls.Add(this.label88);
            this.groupBox_SALPA.Controls.Add(this.numericUpDown_salpa_ahead);
            this.groupBox_SALPA.Controls.Add(this.numericUpDown_salpa_forcepeg);
            this.groupBox_SALPA.Controls.Add(this.numericUpDown_salpa_postpeg);
            this.groupBox_SALPA.Controls.Add(this.numericUpDown_salpa_halfwidth);
            this.groupBox_SALPA.Controls.Add(this.checkBox_SALPA);
            this.groupBox_SALPA.Location = new System.Drawing.Point(5, 133);
            this.groupBox_SALPA.Name = "groupBox_SALPA";
            this.groupBox_SALPA.Size = new System.Drawing.Size(232, 229);
            this.groupBox_SALPA.TabIndex = 37;
            this.groupBox_SALPA.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_Train);
            this.groupBox7.Controls.Add(this.label_noise);
            this.groupBox7.Location = new System.Drawing.Point(6, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(220, 51);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Noise Training";
            // 
            // label_noise
            // 
            this.label_noise.AutoSize = true;
            this.label_noise.ForeColor = System.Drawing.Color.Red;
            this.label_noise.Location = new System.Drawing.Point(97, 0);
            this.label_noise.Name = "label_noise";
            this.label_noise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_noise.Size = new System.Drawing.Size(117, 13);
            this.label_noise.TabIndex = 10;
            this.label_noise.Text = "Noise levels not trained";
            this.label_noise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 205);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Min. Symmetric Samples";
            // 
            // numericUpDown_salpa_asym
            // 
            this.numericUpDown_salpa_asym.Location = new System.Drawing.Point(166, 203);
            this.numericUpDown_salpa_asym.Name = "numericUpDown_salpa_asym";
            this.numericUpDown_salpa_asym.ReadOnly = true;
            this.numericUpDown_salpa_asym.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_salpa_asym.TabIndex = 15;
            this.numericUpDown_salpa_asym.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(6, 175);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(120, 13);
            this.label86.TabIndex = 1;
            this.label86.Text = "Pre-peg blank (samples)";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(6, 115);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(126, 13);
            this.label87.TabIndex = 2;
            this.label87.Text = "Post-peg Blank (samples)";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(6, 145);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(117, 13);
            this.label84.TabIndex = 0;
            this.label84.Text = "Minimum Peg (samples)";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(6, 85);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(104, 13);
            this.label88.TabIndex = 3;
            this.label88.Text = "Half Width (samples)";
            // 
            // numericUpDown_salpa_ahead
            // 
            this.numericUpDown_salpa_ahead.Location = new System.Drawing.Point(166, 173);
            this.numericUpDown_salpa_ahead.Name = "numericUpDown_salpa_ahead";
            this.numericUpDown_salpa_ahead.ReadOnly = true;
            this.numericUpDown_salpa_ahead.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_salpa_ahead.TabIndex = 0;
            this.numericUpDown_salpa_ahead.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_salpa_ahead.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_ahead_ValueChanged);
            // 
            // numericUpDown_salpa_forcepeg
            // 
            this.numericUpDown_salpa_forcepeg.Location = new System.Drawing.Point(165, 143);
            this.numericUpDown_salpa_forcepeg.Name = "numericUpDown_salpa_forcepeg";
            this.numericUpDown_salpa_forcepeg.ReadOnly = true;
            this.numericUpDown_salpa_forcepeg.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_salpa_forcepeg.TabIndex = 1;
            this.numericUpDown_salpa_forcepeg.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_salpa_forcepeg.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_forcepeg_ValueChanged);
            // 
            // numericUpDown_salpa_postpeg
            // 
            this.numericUpDown_salpa_postpeg.Location = new System.Drawing.Point(165, 113);
            this.numericUpDown_salpa_postpeg.Name = "numericUpDown_salpa_postpeg";
            this.numericUpDown_salpa_postpeg.ReadOnly = true;
            this.numericUpDown_salpa_postpeg.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_salpa_postpeg.TabIndex = 2;
            this.numericUpDown_salpa_postpeg.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_postpeg_ValueChanged);
            // 
            // numericUpDown_salpa_halfwidth
            // 
            this.numericUpDown_salpa_halfwidth.Location = new System.Drawing.Point(165, 83);
            this.numericUpDown_salpa_halfwidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_salpa_halfwidth.Name = "numericUpDown_salpa_halfwidth";
            this.numericUpDown_salpa_halfwidth.ReadOnly = true;
            this.numericUpDown_salpa_halfwidth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_salpa_halfwidth.TabIndex = 14;
            this.numericUpDown_salpa_halfwidth.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDown_salpa_halfwidth.ValueChanged += new System.EventHandler(this.numericUpDown_salpa_halfwidth_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.SpikeFiltOrder);
            this.groupBox5.Controls.Add(this.checkBox_spikesFilter);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.SpikeHighCut);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.SpikeLowCut);
            this.groupBox5.Location = new System.Drawing.Point(5, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 108);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Filter Order:";
            // 
            // SpikeFiltOrder
            // 
            this.SpikeFiltOrder.Location = new System.Drawing.Point(165, 74);
            this.SpikeFiltOrder.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SpikeFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpikeFiltOrder.Name = "SpikeFiltOrder";
            this.SpikeFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpikeFiltOrder.Size = new System.Drawing.Size(51, 20);
            this.SpikeFiltOrder.TabIndex = 17;
            this.SpikeFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeFiltOrder.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpikeFiltOrder.ValueChanged += new System.EventHandler(this.SpikeFiltOrder_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "High-Cut Frequency (Hz):";
            // 
            // SpikeHighCut
            // 
            this.SpikeHighCut.Location = new System.Drawing.Point(165, 46);
            this.SpikeHighCut.Maximum = new decimal(new int[] {
            21000,
            0,
            0,
            0});
            this.SpikeHighCut.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpikeHighCut.Name = "SpikeHighCut";
            this.SpikeHighCut.Size = new System.Drawing.Size(51, 20);
            this.SpikeHighCut.TabIndex = 16;
            this.SpikeHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeHighCut.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.SpikeHighCut.ValueChanged += new System.EventHandler(this.SpikeHighCut_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Low-Cut Frequnecy (Hz):";
            // 
            // SpikeLowCut
            // 
            this.SpikeLowCut.Location = new System.Drawing.Point(165, 18);
            this.SpikeLowCut.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.SpikeLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpikeLowCut.Name = "SpikeLowCut";
            this.SpikeLowCut.Size = new System.Drawing.Size(51, 20);
            this.SpikeLowCut.TabIndex = 15;
            this.SpikeLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpikeLowCut.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SpikeLowCut.ValueChanged += new System.EventHandler(this.SpikeLowCut_ValueChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox10.Controls.Add(this.checkBox_freeze);
            this.groupBox10.Controls.Add(this.button_scaleReset);
            this.groupBox10.Controls.Add(this.button_scaleDown);
            this.groupBox10.Controls.Add(this.button_scaleUp);
            this.groupBox10.Location = new System.Drawing.Point(3, 468);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(254, 76);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Display";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_expt
            // 
            this.timer_expt.Interval = 1000;
            this.timer_expt.Tick += new System.EventHandler(this.timer_expt_Tick);
            // 
            // bw_genExpt
            // 
            this.bw_genExpt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_genExpt_DoWork);
            this.bw_genExpt.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_genExpt_RunWorkerCompleted);
            // 
            // bw_stim
            // 
            this.bw_stim.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_stim_DoWork);
            this.bw_stim.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_stim_RunWorkerCompleted);
            // 
            // bw_openLoop
            // 
            this.bw_openLoop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_openLoop_DoWork);
            this.bw_openLoop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_openLoop_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_DisplaySettings,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showConsoleToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "System";
            // 
            // toolStripMenuItem_DisplaySettings
            // 
            this.toolStripMenuItem_DisplaySettings.Name = "toolStripMenuItem_DisplaySettings";
            this.toolStripMenuItem_DisplaySettings.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem_DisplaySettings.Text = "Display Settings";
            this.toolStripMenuItem_DisplaySettings.Click += new System.EventHandler(this.toolStripMenuItem_DisplaySettings_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.settingsToolStripMenuItem.Text = "Hardware Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // showConsoleToolStripMenuItem
            // 
            this.showConsoleToolStripMenuItem.Name = "showConsoleToolStripMenuItem";
            this.showConsoleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showConsoleToolStripMenuItem.Text = "Show Console";
            this.showConsoleToolStripMenuItem.Click += new System.EventHandler(this.showConsoleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documenationToolStripMenuItem,
            this.realTimeAPIReferenceToolStripMenuItem,
            this.codeRespositoryToolStripMenuItem,
            this.closedloopExampleCodesToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documenationToolStripMenuItem
            // 
            this.documenationToolStripMenuItem.Name = "documenationToolStripMenuItem";
            this.documenationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.documenationToolStripMenuItem.Text = "User Manual";
            this.documenationToolStripMenuItem.Click += new System.EventHandler(this.documenationToolStripMenuItem_Click);
            // 
            // realTimeAPIReferenceToolStripMenuItem
            // 
            this.realTimeAPIReferenceToolStripMenuItem.Name = "realTimeAPIReferenceToolStripMenuItem";
            this.realTimeAPIReferenceToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.realTimeAPIReferenceToolStripMenuItem.Text = "Real-Time API Reference";
            this.realTimeAPIReferenceToolStripMenuItem.Click += new System.EventHandler(this.realTimeAPIReferenceToolStripMenuItem_Click);
            // 
            // codeRespositoryToolStripMenuItem
            // 
            this.codeRespositoryToolStripMenuItem.Name = "codeRespositoryToolStripMenuItem";
            this.codeRespositoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.codeRespositoryToolStripMenuItem.Text = "Code Respository";
            this.codeRespositoryToolStripMenuItem.Click += new System.EventHandler(this.codeRespositoryToolStripMenuItem_Click);
            // 
            // closedloopExampleCodesToolStripMenuItem
            // 
            this.closedloopExampleCodesToolStripMenuItem.Name = "closedloopExampleCodesToolStripMenuItem";
            this.closedloopExampleCodesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.closedloopExampleCodesToolStripMenuItem.Text = "Closed-loop Examples";
            this.closedloopExampleCodesToolStripMenuItem.Click += new System.EventHandler(this.closedloopExampleCodesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(100, 800);
            this.panel1.Controls.Add(this.tabControl_sidebar);
            this.panel1.Controls.Add(this.label_timeElapsed);
            this.panel1.Controls.Add(this.groupBox10);
            this.panel1.Controls.Add(this.button_EnterNote);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(950, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 830);
            this.panel1.TabIndex = 18;
            // 
            // tabControl_sidebar
            // 
            this.tabControl_sidebar.Controls.Add(this.tabPage_SpikeFilters);
            this.tabControl_sidebar.Controls.Add(this.tabPage_OtherFilters);
            this.tabControl_sidebar.Controls.Add(this.tabPage_MiscSettings);
            this.tabControl_sidebar.Location = new System.Drawing.Point(2, 0);
            this.tabControl_sidebar.Name = "tabControl_sidebar";
            this.tabControl_sidebar.SelectedIndex = 0;
            this.tabControl_sidebar.Size = new System.Drawing.Size(259, 462);
            this.tabControl_sidebar.TabIndex = 14;
            // 
            // tabPage_SpikeFilters
            // 
            this.tabPage_SpikeFilters.Controls.Add(this.groupBox4);
            this.tabPage_SpikeFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SpikeFilters.Name = "tabPage_SpikeFilters";
            this.tabPage_SpikeFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SpikeFilters.Size = new System.Drawing.Size(251, 436);
            this.tabPage_SpikeFilters.TabIndex = 0;
            this.tabPage_SpikeFilters.Text = "Spike Filtering";
            this.tabPage_SpikeFilters.UseVisualStyleBackColor = true;
            // 
            // tabPage_OtherFilters
            // 
            this.tabPage_OtherFilters.Controls.Add(this.groupBox2);
            this.tabPage_OtherFilters.Controls.Add(this.groupBox36);
            this.tabPage_OtherFilters.Controls.Add(this.groupBox6);
            this.tabPage_OtherFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPage_OtherFilters.Name = "tabPage_OtherFilters";
            this.tabPage_OtherFilters.Size = new System.Drawing.Size(251, 436);
            this.tabPage_OtherFilters.TabIndex = 2;
            this.tabPage_OtherFilters.Text = "Other Filters";
            this.tabPage_OtherFilters.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.EEGFiltOrder);
            this.groupBox2.Controls.Add(this.EEGHighCut);
            this.groupBox2.Controls.Add(this.EEGLowCut);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 106);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filter Order:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "High-Cut Frequency (Hz):";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(7, 24);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(124, 13);
            this.label38.TabIndex = 22;
            this.label38.Text = "Low-Cut Frequnecy (Hz):";
            // 
            // EEGFiltOrder
            // 
            this.EEGFiltOrder.Location = new System.Drawing.Point(173, 78);
            this.EEGFiltOrder.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.EEGFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGFiltOrder.Name = "EEGFiltOrder";
            this.EEGFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EEGFiltOrder.Size = new System.Drawing.Size(51, 20);
            this.EEGFiltOrder.TabIndex = 21;
            this.EEGFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGFiltOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EEGHighCut
            // 
            this.EEGHighCut.Location = new System.Drawing.Point(173, 50);
            this.EEGHighCut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EEGHighCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EEGHighCut.Name = "EEGHighCut";
            this.EEGHighCut.Size = new System.Drawing.Size(51, 20);
            this.EEGHighCut.TabIndex = 20;
            this.EEGHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGHighCut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // EEGLowCut
            // 
            this.EEGLowCut.DecimalPlaces = 2;
            this.EEGLowCut.Location = new System.Drawing.Point(173, 22);
            this.EEGLowCut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.EEGLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EEGLowCut.Name = "EEGLowCut";
            this.EEGLowCut.Size = new System.Drawing.Size(51, 20);
            this.EEGLowCut.TabIndex = 19;
            this.EEGLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EEGLowCut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.label5);
            this.groupBox36.Controls.Add(this.label6);
            this.groupBox36.Controls.Add(this.numericUpDown_MUAFilterOrder);
            this.groupBox36.Controls.Add(this.numericUpDown_MUAHighCut);
            this.groupBox36.Controls.Add(this.checkBox_MUAFilter);
            this.groupBox36.Location = new System.Drawing.Point(6, 155);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(238, 86);
            this.groupBox36.TabIndex = 25;
            this.groupBox36.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Filter Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "High-Cut Frequency (Hz):";
            // 
            // numericUpDown_MUAFilterOrder
            // 
            this.numericUpDown_MUAFilterOrder.Location = new System.Drawing.Point(172, 53);
            this.numericUpDown_MUAFilterOrder.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_MUAFilterOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MUAFilterOrder.Name = "numericUpDown_MUAFilterOrder";
            this.numericUpDown_MUAFilterOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_MUAFilterOrder.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_MUAFilterOrder.TabIndex = 21;
            this.numericUpDown_MUAFilterOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_MUAFilterOrder.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_MUAFilterOrder.ValueChanged += new System.EventHandler(this.numericUpDown_MUAFilterOrder_ValueChanged);
            // 
            // numericUpDown_MUAHighCut
            // 
            this.numericUpDown_MUAHighCut.Location = new System.Drawing.Point(172, 25);
            this.numericUpDown_MUAHighCut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_MUAHighCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MUAHighCut.Name = "numericUpDown_MUAHighCut";
            this.numericUpDown_MUAHighCut.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_MUAHighCut.TabIndex = 20;
            this.numericUpDown_MUAHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_MUAHighCut.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_MUAHighCut.ValueChanged += new System.EventHandler(this.numericUpDown_MUAHighCut_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label71);
            this.groupBox6.Controls.Add(this.label74);
            this.groupBox6.Controls.Add(this.label75);
            this.groupBox6.Controls.Add(this.checkBox_artiFilt);
            this.groupBox6.Controls.Add(this.LFPFiltOrder);
            this.groupBox6.Controls.Add(this.LFPHighCut);
            this.groupBox6.Controls.Add(this.LFPLowCut);
            this.groupBox6.Controls.Add(this.checkBox_LFPsFilter);
            this.groupBox6.Location = new System.Drawing.Point(6, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 137);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(7, 80);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(61, 13);
            this.label71.TabIndex = 24;
            this.label71.Text = "Filter Order:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(7, 52);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(126, 13);
            this.label74.TabIndex = 23;
            this.label74.Text = "High-Cut Frequency (Hz):";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(7, 24);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(124, 13);
            this.label75.TabIndex = 22;
            this.label75.Text = "Low-Cut Frequnecy (Hz):";
            // 
            // LFPFiltOrder
            // 
            this.LFPFiltOrder.Location = new System.Drawing.Point(173, 78);
            this.LFPFiltOrder.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LFPFiltOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPFiltOrder.Name = "LFPFiltOrder";
            this.LFPFiltOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LFPFiltOrder.Size = new System.Drawing.Size(51, 20);
            this.LFPFiltOrder.TabIndex = 21;
            this.LFPFiltOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPFiltOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LFPHighCut
            // 
            this.LFPHighCut.Location = new System.Drawing.Point(173, 50);
            this.LFPHighCut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LFPHighCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LFPHighCut.Name = "LFPHighCut";
            this.LFPHighCut.Size = new System.Drawing.Size(51, 20);
            this.LFPHighCut.TabIndex = 20;
            this.LFPHighCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPHighCut.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // LFPLowCut
            // 
            this.LFPLowCut.DecimalPlaces = 2;
            this.LFPLowCut.Location = new System.Drawing.Point(173, 22);
            this.LFPLowCut.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LFPLowCut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LFPLowCut.Name = "LFPLowCut";
            this.LFPLowCut.Size = new System.Drawing.Size(51, 20);
            this.LFPLowCut.TabIndex = 19;
            this.LFPLowCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LFPLowCut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage_MiscSettings
            // 
            this.tabPage_MiscSettings.Controls.Add(this.groupBox20);
            this.tabPage_MiscSettings.Controls.Add(this.groupBox26);
            this.tabPage_MiscSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MiscSettings.Name = "tabPage_MiscSettings";
            this.tabPage_MiscSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MiscSettings.Size = new System.Drawing.Size(251, 436);
            this.tabPage_MiscSettings.TabIndex = 1;
            this.tabPage_MiscSettings.Text = "Misc. Settings";
            this.tabPage_MiscSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.channelOut);
            this.groupBox20.Controls.Add(this.label18);
            this.groupBox20.Location = new System.Drawing.Point(4, 6);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(243, 53);
            this.groupBox20.TabIndex = 40;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "BNC Output";
            // 
            // channelOut
            // 
            this.channelOut.Enabled = false;
            this.channelOut.Location = new System.Drawing.Point(175, 24);
            this.channelOut.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.channelOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.channelOut.Name = "channelOut";
            this.channelOut.Size = new System.Drawing.Size(53, 20);
            this.channelOut.TabIndex = 19;
            this.channelOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 26);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(162, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "BNC Output Ch # (Experimental):";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.checkBox_video);
            this.groupBox26.Location = new System.Drawing.Point(4, 65);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(243, 47);
            this.groupBox26.TabIndex = 16;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Video recording";
            this.groupBox26.Visible = false;
            // 
            // spkWfmPlot1
            // 
            this.spkWfmPlot1.XAxis = this.xAxis3;
            this.spkWfmPlot1.YAxis = this.yAxis3;
            // 
            // xAxis3
            // 
            this.xAxis3.AutoSpacing = false;
            this.xAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis3.Visible = false;
            // 
            // yAxis3
            // 
            this.yAxis3.AutoSpacing = false;
            this.yAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis3.Visible = false;
            // 
            // timer_timeElapsed
            // 
            this.timer_timeElapsed.Interval = 1000;
            this.timer_timeElapsed.Tick += new System.EventHandler(this.timer_timeElapsed_Tick);
            // 
            // imageList_zoomButtons
            // 
            this.imageList_zoomButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_zoomButtons.ImageStream")));
            this.imageList_zoomButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_zoomButtons.Images.SetKeyName(0, "ZoomInBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(1, "ZoomInBlueBright.png");
            this.imageList_zoomButtons.Images.SetKeyName(2, "ZoomOutBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(3, "ZoomOutBlueBright.png");
            this.imageList_zoomButtons.Images.SetKeyName(4, "ZoomResetBlue.png");
            this.imageList_zoomButtons.Images.SetKeyName(5, "ZoomResetBlueBright.png");
            // 
            // NRPersistWindowComponent
            // 
            this.NRPersistWindowComponent.Form = this;
            this.NRPersistWindowComponent.XMLFilePath = "WindowState.xml";
            // 
            // tabPage_ProgRef
            // 
            this.tabPage_ProgRef.Controls.Add(this.groupBox_plexonProgRef);
            this.tabPage_ProgRef.Controls.Add(this.groupBox13);
            this.tabPage_ProgRef.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ProgRef.Name = "tabPage_ProgRef";
            this.tabPage_ProgRef.Size = new System.Drawing.Size(942, 780);
            this.tabPage_ProgRef.TabIndex = 3;
            this.tabPage_ProgRef.Text = "Referencing";
            this.tabPage_ProgRef.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox25);
            this.groupBox13.Controls.Add(this.checkBox_digRefLFPs);
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.numericUpDown_digRefLFPs);
            this.groupBox13.Controls.Add(this.checkBox_digRefSpikes);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Controls.Add(this.numericUpDown_digRefSpikes);
            this.groupBox13.Location = new System.Drawing.Point(3, 5);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(426, 195);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Floating Reference";
            // 
            // numericUpDown_digRefSpikes
            // 
            this.numericUpDown_digRefSpikes.Location = new System.Drawing.Point(143, 37);
            this.numericUpDown_digRefSpikes.Name = "numericUpDown_digRefSpikes";
            this.numericUpDown_digRefSpikes.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_digRefSpikes.TabIndex = 1;
            this.numericUpDown_digRefSpikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_digRefSpikes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Spike Reference Channel:";
            // 
            // checkBox_digRefSpikes
            // 
            this.checkBox_digRefSpikes.AutoSize = true;
            this.checkBox_digRefSpikes.Location = new System.Drawing.Point(8, 19);
            this.checkBox_digRefSpikes.Name = "checkBox_digRefSpikes";
            this.checkBox_digRefSpikes.Size = new System.Drawing.Size(213, 17);
            this.checkBox_digRefSpikes.TabIndex = 0;
            this.checkBox_digRefSpikes.Text = "Use Single Channel Reference (Spikes)";
            this.checkBox_digRefSpikes.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_digRefLFPs
            // 
            this.numericUpDown_digRefLFPs.Location = new System.Drawing.Point(357, 37);
            this.numericUpDown_digRefLFPs.Name = "numericUpDown_digRefLFPs";
            this.numericUpDown_digRefLFPs.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_digRefLFPs.TabIndex = 3;
            this.numericUpDown_digRefLFPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_digRefLFPs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(227, 39);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 13);
            this.label44.TabIndex = 4;
            this.label44.Text = "LFP Reference Channel:";
            // 
            // checkBox_digRefLFPs
            // 
            this.checkBox_digRefLFPs.AutoSize = true;
            this.checkBox_digRefLFPs.Location = new System.Drawing.Point(230, 19);
            this.checkBox_digRefLFPs.Name = "checkBox_digRefLFPs";
            this.checkBox_digRefLFPs.Size = new System.Drawing.Size(123, 17);
            this.checkBox_digRefLFPs.TabIndex = 2;
            this.checkBox_digRefLFPs.Text = "LFP Referencing On";
            this.checkBox_digRefLFPs.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup);
            this.groupBox25.Controls.Add(this.label83);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonAverage);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonMedian);
            this.groupBox25.Controls.Add(this.radioButton_spikesReferencingCommonMedianLocal);
            this.groupBox25.Controls.Add(this.radioButton_spikeReferencingNone);
            this.groupBox25.Location = new System.Drawing.Point(8, 63);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(200, 128);
            this.groupBox25.TabIndex = 8;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Spike Referencing";
            // 
            // radioButton_spikeReferencingNone
            // 
            this.radioButton_spikeReferencingNone.AutoSize = true;
            this.radioButton_spikeReferencingNone.Checked = true;
            this.radioButton_spikeReferencingNone.Location = new System.Drawing.Point(5, 99);
            this.radioButton_spikeReferencingNone.Name = "radioButton_spikeReferencingNone";
            this.radioButton_spikeReferencingNone.Size = new System.Drawing.Size(51, 17);
            this.radioButton_spikeReferencingNone.TabIndex = 9;
            this.radioButton_spikeReferencingNone.TabStop = true;
            this.radioButton_spikeReferencingNone.Text = "None";
            this.radioButton_spikeReferencingNone.UseVisualStyleBackColor = true;
            this.radioButton_spikeReferencingNone.CheckedChanged += new System.EventHandler(this.radioButton_spikeReferencingNone_CheckedChanged);
            // 
            // radioButton_spikesReferencingCommonMedianLocal
            // 
            this.radioButton_spikesReferencingCommonMedianLocal.AutoSize = true;
            this.radioButton_spikesReferencingCommonMedianLocal.Location = new System.Drawing.Point(6, 63);
            this.radioButton_spikesReferencingCommonMedianLocal.Name = "radioButton_spikesReferencingCommonMedianLocal";
            this.radioButton_spikesReferencingCommonMedianLocal.Size = new System.Drawing.Size(133, 17);
            this.radioButton_spikesReferencingCommonMedianLocal.TabIndex = 9;
            this.radioButton_spikesReferencingCommonMedianLocal.Text = "Common Median Local";
            this.radioButton_spikesReferencingCommonMedianLocal.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonMedianLocal.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonMedianLocal_CheckedChanged);
            // 
            // radioButton_spikesReferencingCommonMedian
            // 
            this.radioButton_spikesReferencingCommonMedian.AutoSize = true;
            this.radioButton_spikesReferencingCommonMedian.Location = new System.Drawing.Point(6, 40);
            this.radioButton_spikesReferencingCommonMedian.Name = "radioButton_spikesReferencingCommonMedian";
            this.radioButton_spikesReferencingCommonMedian.Size = new System.Drawing.Size(104, 17);
            this.radioButton_spikesReferencingCommonMedian.TabIndex = 9;
            this.radioButton_spikesReferencingCommonMedian.Text = "Common Median";
            this.radioButton_spikesReferencingCommonMedian.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonMedian.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonMedian_CheckedChanged);
            // 
            // radioButton_spikesReferencingCommonAverage
            // 
            this.radioButton_spikesReferencingCommonAverage.AutoSize = true;
            this.radioButton_spikesReferencingCommonAverage.Location = new System.Drawing.Point(6, 17);
            this.radioButton_spikesReferencingCommonAverage.Name = "radioButton_spikesReferencingCommonAverage";
            this.radioButton_spikesReferencingCommonAverage.Size = new System.Drawing.Size(109, 17);
            this.radioButton_spikesReferencingCommonAverage.TabIndex = 9;
            this.radioButton_spikesReferencingCommonAverage.Text = "Common Average";
            this.radioButton_spikesReferencingCommonAverage.UseVisualStyleBackColor = true;
            this.radioButton_spikesReferencingCommonAverage.CheckedChanged += new System.EventHandler(this.radioButton_spikesReferencingCommonAverage_CheckedChanged);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(32, 83);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(102, 13);
            this.label83.TabIndex = 10;
            this.label83.Text = "Channels per group:";
            // 
            // numericUpDown_CommonMedianLocalReferencingChannelsPerGroup
            // 
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Location = new System.Drawing.Point(140, 81);
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Name = "numericUpDown_CommonMedianLocalReferencingChannelsPerGroup";
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.TabIndex = 9;
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup.ValueChanged += new System.EventHandler(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup_ValueChanged);
            // 
            // groupBox_plexonProgRef
            // 
            this.groupBox_plexonProgRef.Controls.Add(this.button_analogResetRefs);
            this.groupBox_plexonProgRef.Controls.Add(this.checkBox_analogRefLFPs);
            this.groupBox_plexonProgRef.Controls.Add(this.label47);
            this.groupBox_plexonProgRef.Controls.Add(this.numericUpDown_analogRefLFPs);
            this.groupBox_plexonProgRef.Controls.Add(this.checkBox_analogRefSpikes);
            this.groupBox_plexonProgRef.Controls.Add(this.label48);
            this.groupBox_plexonProgRef.Controls.Add(this.numericUpDown_analogRefSpikes);
            this.groupBox_plexonProgRef.Location = new System.Drawing.Point(3, 209);
            this.groupBox_plexonProgRef.Name = "groupBox_plexonProgRef";
            this.groupBox_plexonProgRef.Size = new System.Drawing.Size(426, 95);
            this.groupBox_plexonProgRef.TabIndex = 1;
            this.groupBox_plexonProgRef.TabStop = false;
            this.groupBox_plexonProgRef.Text = "Floating Hardware-Based Referencing (Plexon Only)";
            // 
            // numericUpDown_analogRefSpikes
            // 
            this.numericUpDown_analogRefSpikes.Location = new System.Drawing.Point(143, 37);
            this.numericUpDown_analogRefSpikes.Name = "numericUpDown_analogRefSpikes";
            this.numericUpDown_analogRefSpikes.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_analogRefSpikes.TabIndex = 1;
            this.numericUpDown_analogRefSpikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_analogRefSpikes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_analogRefSpikes.ValueChanged += new System.EventHandler(this.numericUpDown_analogRefSpikes_ValueChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(5, 39);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(132, 13);
            this.label48.TabIndex = 1;
            this.label48.Text = "Spike Reference Channel:";
            // 
            // checkBox_analogRefSpikes
            // 
            this.checkBox_analogRefSpikes.AutoSize = true;
            this.checkBox_analogRefSpikes.Location = new System.Drawing.Point(8, 19);
            this.checkBox_analogRefSpikes.Name = "checkBox_analogRefSpikes";
            this.checkBox_analogRefSpikes.Size = new System.Drawing.Size(131, 17);
            this.checkBox_analogRefSpikes.TabIndex = 0;
            this.checkBox_analogRefSpikes.Text = "Spike Referencing On";
            this.checkBox_analogRefSpikes.UseVisualStyleBackColor = true;
            this.checkBox_analogRefSpikes.CheckedChanged += new System.EventHandler(this.checkBox_analogRefSpikes_CheckedChanged);
            // 
            // numericUpDown_analogRefLFPs
            // 
            this.numericUpDown_analogRefLFPs.Location = new System.Drawing.Point(357, 37);
            this.numericUpDown_analogRefLFPs.Name = "numericUpDown_analogRefLFPs";
            this.numericUpDown_analogRefLFPs.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_analogRefLFPs.TabIndex = 3;
            this.numericUpDown_analogRefLFPs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_analogRefLFPs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_analogRefLFPs.ValueChanged += new System.EventHandler(this.numericUpDown_analogRefLFPs_ValueChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(227, 39);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(124, 13);
            this.label47.TabIndex = 4;
            this.label47.Text = "LFP Reference Channel:";
            // 
            // checkBox_analogRefLFPs
            // 
            this.checkBox_analogRefLFPs.AutoSize = true;
            this.checkBox_analogRefLFPs.Location = new System.Drawing.Point(230, 19);
            this.checkBox_analogRefLFPs.Name = "checkBox_analogRefLFPs";
            this.checkBox_analogRefLFPs.Size = new System.Drawing.Size(123, 17);
            this.checkBox_analogRefLFPs.TabIndex = 2;
            this.checkBox_analogRefLFPs.Text = "LFP Referencing On";
            this.checkBox_analogRefLFPs.UseVisualStyleBackColor = true;
            this.checkBox_analogRefLFPs.CheckedChanged += new System.EventHandler(this.checkBox_analogRefLFPs_CheckedChanged);
            // 
            // button_analogResetRefs
            // 
            this.button_analogResetRefs.Location = new System.Drawing.Point(345, 63);
            this.button_analogResetRefs.Name = "button_analogResetRefs";
            this.button_analogResetRefs.Size = new System.Drawing.Size(75, 23);
            this.button_analogResetRefs.TabIndex = 4;
            this.button_analogResetRefs.Text = "Reset All";
            this.button_analogResetRefs.UseVisualStyleBackColor = true;
            this.button_analogResetRefs.Click += new System.EventHandler(this.button_analogResetRefs_Click);
            // 
            // tabPage_impedance
            // 
            this.tabPage_impedance.Controls.Add(this.groupBox21);
            this.tabPage_impedance.Controls.Add(this.scatterGraph_impedance);
            this.tabPage_impedance.Controls.Add(this.groupBox17);
            this.tabPage_impedance.Controls.Add(this.groupBox16);
            this.tabPage_impedance.Controls.Add(this.groupBox31);
            this.tabPage_impedance.Location = new System.Drawing.Point(4, 22);
            this.tabPage_impedance.Name = "tabPage_impedance";
            this.tabPage_impedance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_impedance.Size = new System.Drawing.Size(942, 780);
            this.tabPage_impedance.TabIndex = 5;
            this.tabPage_impedance.Text = "Impedance";
            this.tabPage_impedance.UseVisualStyleBackColor = true;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label_impedanceProgress);
            this.groupBox31.Controls.Add(this.button_impedanceSaveAsMAT);
            this.groupBox31.Controls.Add(this.progressBar_impedance);
            this.groupBox31.Controls.Add(this.button_impedanceTest);
            this.groupBox31.Controls.Add(this.button_impedanceCancel);
            this.groupBox31.Controls.Add(this.button_impedanceCopyDataToClipboard);
            this.groupBox31.Location = new System.Drawing.Point(10, 63);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(209, 148);
            this.groupBox31.TabIndex = 26;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Test Control";
            // 
            // button_impedanceCopyDataToClipboard
            // 
            this.button_impedanceCopyDataToClipboard.Location = new System.Drawing.Point(6, 107);
            this.button_impedanceCopyDataToClipboard.Name = "button_impedanceCopyDataToClipboard";
            this.button_impedanceCopyDataToClipboard.Size = new System.Drawing.Size(94, 35);
            this.button_impedanceCopyDataToClipboard.TabIndex = 6;
            this.button_impedanceCopyDataToClipboard.Text = "Copy Data to Clipboard";
            this.button_impedanceCopyDataToClipboard.UseVisualStyleBackColor = true;
            this.button_impedanceCopyDataToClipboard.Click += new System.EventHandler(this.button_impedanceCopyDataToClipboard_Click);
            // 
            // button_impedanceCancel
            // 
            this.button_impedanceCancel.Enabled = false;
            this.button_impedanceCancel.Location = new System.Drawing.Point(109, 20);
            this.button_impedanceCancel.Name = "button_impedanceCancel";
            this.button_impedanceCancel.Size = new System.Drawing.Size(94, 29);
            this.button_impedanceCancel.TabIndex = 1;
            this.button_impedanceCancel.Text = "Cancel";
            this.button_impedanceCancel.UseVisualStyleBackColor = true;
            this.button_impedanceCancel.Click += new System.EventHandler(this.button_impedanceCancel_Click);
            // 
            // button_impedanceTest
            // 
            this.button_impedanceTest.Location = new System.Drawing.Point(6, 20);
            this.button_impedanceTest.Name = "button_impedanceTest";
            this.button_impedanceTest.Size = new System.Drawing.Size(94, 29);
            this.button_impedanceTest.TabIndex = 0;
            this.button_impedanceTest.Text = "Test impedance";
            this.button_impedanceTest.UseVisualStyleBackColor = true;
            this.button_impedanceTest.Click += new System.EventHandler(this.button_impedanceTest_Click);
            // 
            // progressBar_impedance
            // 
            this.progressBar_impedance.Location = new System.Drawing.Point(6, 53);
            this.progressBar_impedance.Name = "progressBar_impedance";
            this.progressBar_impedance.Size = new System.Drawing.Size(197, 30);
            this.progressBar_impedance.TabIndex = 25;
            // 
            // button_impedanceSaveAsMAT
            // 
            this.button_impedanceSaveAsMAT.Location = new System.Drawing.Point(109, 107);
            this.button_impedanceSaveAsMAT.Name = "button_impedanceSaveAsMAT";
            this.button_impedanceSaveAsMAT.Size = new System.Drawing.Size(94, 35);
            this.button_impedanceSaveAsMAT.TabIndex = 7;
            this.button_impedanceSaveAsMAT.Text = "Save Data as Matlab MAT File";
            this.button_impedanceSaveAsMAT.UseVisualStyleBackColor = true;
            this.button_impedanceSaveAsMAT.Click += new System.EventHandler(this.button_impedanceSaveAsMAT_Click);
            // 
            // label_impedanceProgress
            // 
            this.label_impedanceProgress.AutoSize = true;
            this.label_impedanceProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_impedanceProgress.ForeColor = System.Drawing.Color.DimGray;
            this.label_impedanceProgress.Location = new System.Drawing.Point(97, 86);
            this.label_impedanceProgress.Name = "label_impedanceProgress";
            this.label_impedanceProgress.Size = new System.Drawing.Size(104, 13);
            this.label_impedanceProgress.TabIndex = 26;
            this.label_impedanceProgress.Text = "Impedance Progress";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.checkBox_impUseMatchedFilter);
            this.groupBox16.Controls.Add(this.checkBox_impBandpassFilter);
            this.groupBox16.Controls.Add(this.label32);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.Controls.Add(this.numericUpDown_impNumPeriods);
            this.groupBox16.Controls.Add(this.label46);
            this.groupBox16.Controls.Add(this.numericUpDown_impStartFreq);
            this.groupBox16.Controls.Add(this.label43);
            this.groupBox16.Controls.Add(this.numericUpDown_impStopFreq);
            this.groupBox16.Controls.Add(this.numericUpDown_impCommandVoltage);
            this.groupBox16.Controls.Add(this.label30);
            this.groupBox16.Controls.Add(this.label29);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Controls.Add(this.numericUpDown_RMeas);
            this.groupBox16.Controls.Add(this.numericUpDown_RGain);
            this.groupBox16.Controls.Add(this.numericUpDown_RCurr);
            this.groupBox16.Controls.Add(this.groupBox15);
            this.groupBox16.Location = new System.Drawing.Point(233, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(383, 209);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Parameters";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.radioButton_impVoltage);
            this.groupBox15.Controls.Add(this.radioButton_impCurrent);
            this.groupBox15.Location = new System.Drawing.Point(6, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(168, 39);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Current vs. Voltage Control";
            // 
            // radioButton_impCurrent
            // 
            this.radioButton_impCurrent.AutoSize = true;
            this.radioButton_impCurrent.Checked = true;
            this.radioButton_impCurrent.Location = new System.Drawing.Point(6, 16);
            this.radioButton_impCurrent.Name = "radioButton_impCurrent";
            this.radioButton_impCurrent.Size = new System.Drawing.Size(59, 17);
            this.radioButton_impCurrent.TabIndex = 0;
            this.radioButton_impCurrent.TabStop = true;
            this.radioButton_impCurrent.Text = "Current";
            this.radioButton_impCurrent.UseVisualStyleBackColor = true;
            this.radioButton_impCurrent.Click += new System.EventHandler(this.radioButton_impCurrent_Click);
            // 
            // radioButton_impVoltage
            // 
            this.radioButton_impVoltage.AutoSize = true;
            this.radioButton_impVoltage.Location = new System.Drawing.Point(81, 16);
            this.radioButton_impVoltage.Name = "radioButton_impVoltage";
            this.radioButton_impVoltage.Size = new System.Drawing.Size(61, 17);
            this.radioButton_impVoltage.TabIndex = 1;
            this.radioButton_impVoltage.Text = "Voltage";
            this.radioButton_impVoltage.UseVisualStyleBackColor = true;
            this.radioButton_impVoltage.Click += new System.EventHandler(this.radioButton_impVoltage_Click);
            // 
            // numericUpDown_RCurr
            // 
            this.numericUpDown_RCurr.Location = new System.Drawing.Point(111, 68);
            this.numericUpDown_RCurr.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_RCurr.Name = "numericUpDown_RCurr";
            this.numericUpDown_RCurr.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RCurr.TabIndex = 2;
            this.numericUpDown_RCurr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RCurr.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // numericUpDown_RGain
            // 
            this.numericUpDown_RGain.Location = new System.Drawing.Point(111, 104);
            this.numericUpDown_RGain.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_RGain.Name = "numericUpDown_RGain";
            this.numericUpDown_RGain.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RGain.TabIndex = 3;
            this.numericUpDown_RGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RGain.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_RMeas
            // 
            this.numericUpDown_RMeas.Location = new System.Drawing.Point(111, 140);
            this.numericUpDown_RMeas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_RMeas.Name = "numericUpDown_RMeas";
            this.numericUpDown_RMeas.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_RMeas.TabIndex = 4;
            this.numericUpDown_RMeas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_RMeas.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "R_current (Ohms):";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 106);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "R_Gain (Ohms):";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 13);
            this.label30.TabIndex = 12;
            this.label30.Text = "R_Meas (Ohms):";
            // 
            // numericUpDown_impCommandVoltage
            // 
            this.numericUpDown_impCommandVoltage.DecimalPlaces = 2;
            this.numericUpDown_impCommandVoltage.Location = new System.Drawing.Point(111, 176);
            this.numericUpDown_impCommandVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_impCommandVoltage.Name = "numericUpDown_impCommandVoltage";
            this.numericUpDown_impCommandVoltage.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impCommandVoltage.TabIndex = 5;
            this.numericUpDown_impCommandVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impCommandVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown_impStopFreq
            // 
            this.numericUpDown_impStopFreq.DecimalPlaces = 1;
            this.numericUpDown_impStopFreq.Location = new System.Drawing.Point(313, 104);
            this.numericUpDown_impStopFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impStopFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impStopFreq.Name = "numericUpDown_impStopFreq";
            this.numericUpDown_impStopFreq.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impStopFreq.TabIndex = 7;
            this.numericUpDown_impStopFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(201, 31);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(87, 13);
            this.label43.TabIndex = 24;
            this.label43.Text = "Periods per freq.:";
            // 
            // numericUpDown_impStartFreq
            // 
            this.numericUpDown_impStartFreq.DecimalPlaces = 1;
            this.numericUpDown_impStartFreq.Location = new System.Drawing.Point(313, 68);
            this.numericUpDown_impStartFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impStartFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_impStartFreq.Name = "numericUpDown_impStartFreq";
            this.numericUpDown_impStartFreq.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impStartFreq.TabIndex = 6;
            this.numericUpDown_impStartFreq.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(200, 70);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(107, 13);
            this.label46.TabIndex = 19;
            this.label46.Text = "Start Frequency (Hz):";
            // 
            // numericUpDown_impNumPeriods
            // 
            this.numericUpDown_impNumPeriods.DecimalPlaces = 1;
            this.numericUpDown_impNumPeriods.Location = new System.Drawing.Point(313, 29);
            this.numericUpDown_impNumPeriods.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_impNumPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impNumPeriods.Name = "numericUpDown_impNumPeriods";
            this.numericUpDown_impNumPeriods.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_impNumPeriods.TabIndex = 1;
            this.numericUpDown_impNumPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impNumPeriods.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(201, 106);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(107, 13);
            this.label45.TabIndex = 20;
            this.label45.Text = "Stop Frequency (Hz):";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 178);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 13);
            this.label32.TabIndex = 14;
            this.label32.Text = "Voltage (V):";
            // 
            // checkBox_impBandpassFilter
            // 
            this.checkBox_impBandpassFilter.AutoSize = true;
            this.checkBox_impBandpassFilter.Location = new System.Drawing.Point(204, 140);
            this.checkBox_impBandpassFilter.Name = "checkBox_impBandpassFilter";
            this.checkBox_impBandpassFilter.Size = new System.Drawing.Size(120, 17);
            this.checkBox_impBandpassFilter.TabIndex = 8;
            this.checkBox_impBandpassFilter.Text = "Use Bandpass Filter";
            this.checkBox_impBandpassFilter.UseVisualStyleBackColor = true;
            // 
            // checkBox_impUseMatchedFilter
            // 
            this.checkBox_impUseMatchedFilter.AutoSize = true;
            this.checkBox_impUseMatchedFilter.Checked = true;
            this.checkBox_impUseMatchedFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_impUseMatchedFilter.Location = new System.Drawing.Point(204, 176);
            this.checkBox_impUseMatchedFilter.Name = "checkBox_impUseMatchedFilter";
            this.checkBox_impUseMatchedFilter.Size = new System.Drawing.Size(115, 17);
            this.checkBox_impUseMatchedFilter.TabIndex = 9;
            this.checkBox_impUseMatchedFilter.Text = "Use Matched Filter";
            this.checkBox_impUseMatchedFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox_impedanceResults);
            this.groupBox17.Location = new System.Drawing.Point(622, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(313, 208);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Results (Ohms)";
            // 
            // textBox_impedanceResults
            // 
            this.textBox_impedanceResults.Location = new System.Drawing.Point(6, 19);
            this.textBox_impedanceResults.Multiline = true;
            this.textBox_impedanceResults.Name = "textBox_impedanceResults";
            this.textBox_impedanceResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_impedanceResults.Size = new System.Drawing.Size(301, 183);
            this.textBox_impedanceResults.TabIndex = 0;
            // 
            // scatterGraph_impedance
            // 
            this.scatterGraph_impedance.Location = new System.Drawing.Point(10, 220);
            this.scatterGraph_impedance.Name = "scatterGraph_impedance";
            this.scatterGraph_impedance.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot2});
            this.scatterGraph_impedance.Size = new System.Drawing.Size(925, 553);
            this.scatterGraph_impedance.TabIndex = 25;
            this.scatterGraph_impedance.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.scatterGraph_impedance.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // yAxis2
            // 
            this.yAxis2.Caption = "Impedance (Ohms)";
            this.yAxis2.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // xAxis2
            // 
            this.xAxis2.Caption = "Frequency (Hz)";
            this.xAxis2.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // scatterPlot2
            // 
            this.scatterPlot2.ProcessSpecialValues = true;
            this.scatterPlot2.XAxis = this.xAxis2;
            this.scatterPlot2.YAxis = this.yAxis2;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.checkBox_impedanceAllChannels);
            this.groupBox21.Controls.Add(this.numericUpDown_impChannel);
            this.groupBox21.Location = new System.Drawing.Point(10, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(209, 51);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Channel";
            // 
            // numericUpDown_impChannel
            // 
            this.numericUpDown_impChannel.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_impChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_impChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_impChannel.Name = "numericUpDown_impChannel";
            this.numericUpDown_impChannel.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_impChannel.TabIndex = 0;
            this.numericUpDown_impChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_impChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_impedanceAllChannels
            // 
            this.checkBox_impedanceAllChannels.AutoSize = true;
            this.checkBox_impedanceAllChannels.Location = new System.Drawing.Point(117, 20);
            this.checkBox_impedanceAllChannels.Name = "checkBox_impedanceAllChannels";
            this.checkBox_impedanceAllChannels.Size = new System.Drawing.Size(84, 17);
            this.checkBox_impedanceAllChannels.TabIndex = 1;
            this.checkBox_impedanceAllChannels.Text = "All Channels";
            this.checkBox_impedanceAllChannels.UseVisualStyleBackColor = true;
            this.checkBox_impedanceAllChannels.CheckedChanged += new System.EventHandler(this.checkBox_impedanceAllChannels_CheckedChanged);
            // 
            // tabPage_stim
            // 
            this.tabPage_stim.Controls.Add(this.groupBox35);
            this.tabPage_stim.Controls.Add(this.groupBox30);
            this.tabPage_stim.Controls.Add(this.groupBox24);
            this.tabPage_stim.Controls.Add(this.groupBox23);
            this.tabPage_stim.Controls.Add(this.groupBox22);
            this.tabPage_stim.Controls.Add(this.groupBox12);
            this.tabPage_stim.Controls.Add(this.groupBox11);
            this.tabPage_stim.Controls.Add(this.groupBox9);
            this.tabPage_stim.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stim.Name = "tabPage_stim";
            this.tabPage_stim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stim.Size = new System.Drawing.Size(942, 780);
            this.tabPage_stim.TabIndex = 4;
            this.tabPage_stim.Text = "Stim/Output";
            this.tabPage_stim.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox29);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.stimInterphaseLength);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.stimChannel);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.stimWidth);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.stimRate);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.stimVoltage);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.stimPulses);
            this.groupBox9.Controls.Add(this.button_stim);
            this.groupBox9.Location = new System.Drawing.Point(8, 82);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(321, 153);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "On Demand";
            // 
            // button_stim
            // 
            this.button_stim.Location = new System.Drawing.Point(241, 99);
            this.button_stim.Name = "button_stim";
            this.button_stim.Size = new System.Drawing.Size(61, 41);
            this.button_stim.TabIndex = 0;
            this.button_stim.Text = "Stimulate";
            this.button_stim.UseVisualStyleBackColor = true;
            this.button_stim.Click += new System.EventHandler(this.button_stim_Click);
            // 
            // stimPulses
            // 
            this.stimPulses.Location = new System.Drawing.Point(73, 46);
            this.stimPulses.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.stimPulses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimPulses.Name = "stimPulses";
            this.stimPulses.Size = new System.Drawing.Size(52, 20);
            this.stimPulses.TabIndex = 1;
            this.stimPulses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "# Pulses:";
            // 
            // stimVoltage
            // 
            this.stimVoltage.DecimalPlaces = 1;
            this.stimVoltage.Location = new System.Drawing.Point(256, 19);
            this.stimVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stimVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.stimVoltage.Name = "stimVoltage";
            this.stimVoltage.Size = new System.Drawing.Size(52, 20);
            this.stimVoltage.TabIndex = 2;
            this.stimVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Voltage (V):";
            // 
            // stimRate
            // 
            this.stimRate.DecimalPlaces = 2;
            this.stimRate.Location = new System.Drawing.Point(73, 72);
            this.stimRate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.stimRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stimRate.Name = "stimRate";
            this.stimRate.Size = new System.Drawing.Size(52, 20);
            this.stimRate.TabIndex = 3;
            this.stimRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Rate (Hz):";
            // 
            // stimWidth
            // 
            this.stimWidth.Location = new System.Drawing.Point(256, 45);
            this.stimWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stimWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimWidth.Name = "stimWidth";
            this.stimWidth.Size = new System.Drawing.Size(52, 20);
            this.stimWidth.TabIndex = 4;
            this.stimWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(131, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Phase width (μs):";
            // 
            // stimChannel
            // 
            this.stimChannel.Location = new System.Drawing.Point(73, 20);
            this.stimChannel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.stimChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stimChannel.Name = "stimChannel";
            this.stimChannel.Size = new System.Drawing.Size(52, 20);
            this.stimChannel.TabIndex = 6;
            this.stimChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Channel:";
            // 
            // stimInterphaseLength
            // 
            this.stimInterphaseLength.Location = new System.Drawing.Point(256, 72);
            this.stimInterphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.stimInterphaseLength.Name = "stimInterphaseLength";
            this.stimInterphaseLength.Size = new System.Drawing.Size(52, 20);
            this.stimInterphaseLength.TabIndex = 5;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(131, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Interphase length (μs):";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.radioButton_OnDemandBiphasic);
            this.groupBox29.Controls.Add(this.radioButton_OnDemandUniphasic);
            this.groupBox29.Location = new System.Drawing.Point(9, 98);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(158, 39);
            this.groupBox29.TabIndex = 2;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Uni- vs. Biphasic Pulses";
            // 
            // radioButton_OnDemandUniphasic
            // 
            this.radioButton_OnDemandUniphasic.AutoSize = true;
            this.radioButton_OnDemandUniphasic.Location = new System.Drawing.Point(6, 16);
            this.radioButton_OnDemandUniphasic.Name = "radioButton_OnDemandUniphasic";
            this.radioButton_OnDemandUniphasic.Size = new System.Drawing.Size(72, 17);
            this.radioButton_OnDemandUniphasic.TabIndex = 0;
            this.radioButton_OnDemandUniphasic.Text = "Uniphasic";
            this.radioButton_OnDemandUniphasic.UseVisualStyleBackColor = true;
            // 
            // radioButton_OnDemandBiphasic
            // 
            this.radioButton_OnDemandBiphasic.AutoSize = true;
            this.radioButton_OnDemandBiphasic.Checked = true;
            this.radioButton_OnDemandBiphasic.Location = new System.Drawing.Point(91, 16);
            this.radioButton_OnDemandBiphasic.Name = "radioButton_OnDemandBiphasic";
            this.radioButton_OnDemandBiphasic.Size = new System.Drawing.Size(65, 17);
            this.radioButton_OnDemandBiphasic.TabIndex = 1;
            this.radioButton_OnDemandBiphasic.TabStop = true;
            this.radioButton_OnDemandBiphasic.Text = "Biphasic";
            this.toolTip_outputFilename.SetToolTip(this.radioButton_OnDemandBiphasic, "2nd phase negative of first");
            this.radioButton_OnDemandBiphasic.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_ElectrodeScreeningSelectNone);
            this.groupBox11.Controls.Add(this.label60);
            this.groupBox11.Controls.Add(this.button_ElectrodeScreeningSelectAll);
            this.groupBox11.Controls.Add(this.numericUpDown_exptNumRepeats);
            this.groupBox11.Controls.Add(this.label59);
            this.groupBox11.Controls.Add(this.textBox_exptPulseWidths);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.textBox_exptPPT);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Controls.Add(this.textBox_exptVoltages);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.button_stopExpt);
            this.groupBox11.Controls.Add(this.listBox_exptStimChannels);
            this.groupBox11.Controls.Add(this.progressBar_stimExpt);
            this.groupBox11.Controls.Add(this.button_stimExpt);
            this.groupBox11.Location = new System.Drawing.Point(340, 402);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(399, 216);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Electrode Screening";
            // 
            // button_stimExpt
            // 
            this.button_stimExpt.Location = new System.Drawing.Point(227, 130);
            this.button_stimExpt.Name = "button_stimExpt";
            this.button_stimExpt.Size = new System.Drawing.Size(74, 38);
            this.button_stimExpt.TabIndex = 0;
            this.button_stimExpt.Text = "Start Experiment";
            this.button_stimExpt.UseVisualStyleBackColor = true;
            this.button_stimExpt.Click += new System.EventHandler(this.button_stimExpt_Click);
            // 
            // progressBar_stimExpt
            // 
            this.progressBar_stimExpt.Location = new System.Drawing.Point(121, 181);
            this.progressBar_stimExpt.Name = "progressBar_stimExpt";
            this.progressBar_stimExpt.Size = new System.Drawing.Size(272, 23);
            this.progressBar_stimExpt.TabIndex = 4;
            // 
            // listBox_exptStimChannels
            // 
            this.listBox_exptStimChannels.FormattingEnabled = true;
            this.listBox_exptStimChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_exptStimChannels.Location = new System.Drawing.Point(9, 32);
            this.listBox_exptStimChannels.Name = "listBox_exptStimChannels";
            this.listBox_exptStimChannels.ScrollAlwaysVisible = true;
            this.listBox_exptStimChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_exptStimChannels.Size = new System.Drawing.Size(106, 134);
            this.listBox_exptStimChannels.TabIndex = 2;
            // 
            // button_stopExpt
            // 
            this.button_stopExpt.Enabled = false;
            this.button_stopExpt.Location = new System.Drawing.Point(319, 130);
            this.button_stopExpt.Name = "button_stopExpt";
            this.button_stopExpt.Size = new System.Drawing.Size(74, 38);
            this.button_stopExpt.TabIndex = 1;
            this.button_stopExpt.Text = "Stop Experiment";
            this.button_stopExpt.UseVisualStyleBackColor = true;
            this.button_stopExpt.Click += new System.EventHandler(this.button_stopExpt_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(109, 13);
            this.label37.TabIndex = 28;
            this.label37.Text = "Channels to Stimulate";
            // 
            // textBox_exptVoltages
            // 
            this.textBox_exptVoltages.Location = new System.Drawing.Point(121, 33);
            this.textBox_exptVoltages.Multiline = true;
            this.textBox_exptVoltages.Name = "textBox_exptVoltages";
            this.textBox_exptVoltages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptVoltages.Size = new System.Drawing.Size(100, 45);
            this.textBox_exptVoltages.TabIndex = 3;
            this.textBox_exptVoltages.Text = "-0.2, -0.4, -0.6, -0.8, -1.0, -1.5, -2.0, -5.0";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(118, 16);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(64, 13);
            this.label57.TabIndex = 30;
            this.label57.Text = "Voltages (V)";
            // 
            // textBox_exptPPT
            // 
            this.textBox_exptPPT.Location = new System.Drawing.Point(121, 100);
            this.textBox_exptPPT.Multiline = true;
            this.textBox_exptPPT.Name = "textBox_exptPPT";
            this.textBox_exptPPT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptPPT.Size = new System.Drawing.Size(81, 66);
            this.textBox_exptPPT.TabIndex = 5;
            this.textBox_exptPPT.Text = "1";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(118, 83);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(84, 13);
            this.label58.TabIndex = 32;
            this.label58.Text = "Pulses Per Train";
            // 
            // textBox_exptPulseWidths
            // 
            this.textBox_exptPulseWidths.Location = new System.Drawing.Point(230, 33);
            this.textBox_exptPulseWidths.Multiline = true;
            this.textBox_exptPulseWidths.Name = "textBox_exptPulseWidths";
            this.textBox_exptPulseWidths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_exptPulseWidths.Size = new System.Drawing.Size(72, 45);
            this.textBox_exptPulseWidths.TabIndex = 4;
            this.textBox_exptPulseWidths.Text = "400.0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(227, 16);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 13);
            this.label59.TabIndex = 34;
            this.label59.Text = "Pulse Widths (μs)";
            // 
            // numericUpDown_exptNumRepeats
            // 
            this.numericUpDown_exptNumRepeats.Location = new System.Drawing.Point(323, 33);
            this.numericUpDown_exptNumRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_exptNumRepeats.Name = "numericUpDown_exptNumRepeats";
            this.numericUpDown_exptNumRepeats.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_exptNumRepeats.TabIndex = 6;
            this.numericUpDown_exptNumRepeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_exptNumRepeats.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_ElectrodeScreeningSelectAll
            // 
            this.button_ElectrodeScreeningSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ElectrodeScreeningSelectAll.Location = new System.Drawing.Point(56, 173);
            this.button_ElectrodeScreeningSelectAll.Name = "button_ElectrodeScreeningSelectAll";
            this.button_ElectrodeScreeningSelectAll.Size = new System.Drawing.Size(35, 31);
            this.button_ElectrodeScreeningSelectAll.TabIndex = 22;
            this.button_ElectrodeScreeningSelectAll.Text = "Select All";
            this.button_ElectrodeScreeningSelectAll.UseVisualStyleBackColor = true;
            this.button_ElectrodeScreeningSelectAll.Click += new System.EventHandler(this.button_ElectrodeScreeningSelectAll_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(320, 17);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 13);
            this.label60.TabIndex = 36;
            this.label60.Text = "Num Repeats";
            // 
            // button_ElectrodeScreeningSelectNone
            // 
            this.button_ElectrodeScreeningSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ElectrodeScreeningSelectNone.Location = new System.Drawing.Point(15, 173);
            this.button_ElectrodeScreeningSelectNone.Name = "button_ElectrodeScreeningSelectNone";
            this.button_ElectrodeScreeningSelectNone.Size = new System.Drawing.Size(35, 31);
            this.button_ElectrodeScreeningSelectNone.TabIndex = 23;
            this.button_ElectrodeScreeningSelectNone.Text = "Select None";
            this.button_ElectrodeScreeningSelectNone.UseVisualStyleBackColor = true;
            this.button_ElectrodeScreeningSelectNone.Click += new System.EventHandler(this.button_ElectrodeScreeningSelectNone_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.waveformGraph_openLoopStimPulse);
            this.groupBox12.Controls.Add(this.button_openLoopSelectNone);
            this.groupBox12.Controls.Add(this.button_openLoopSelectAll);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.openLoopPostphaseLength);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.openLoopPrephaseLength);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.openLoopWidth2);
            this.groupBox12.Controls.Add(this.label7);
            this.groupBox12.Controls.Add(this.openLoopVoltage2);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Controls.Add(this.openLoopInterphaseLength);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.listBox_stimChannels);
            this.groupBox12.Controls.Add(this.openLoopStop);
            this.groupBox12.Controls.Add(this.openLoopStart);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.openLoopWidth1);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.openLoopVoltage1);
            this.groupBox12.Controls.Add(this.label19);
            this.groupBox12.Controls.Add(this.openLoopRate);
            this.groupBox12.Location = new System.Drawing.Point(8, 241);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(321, 377);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Manual Stim";
            // 
            // openLoopRate
            // 
            this.openLoopRate.DecimalPlaces = 2;
            this.openLoopRate.Location = new System.Drawing.Point(128, 25);
            this.openLoopRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.openLoopRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.openLoopRate.Name = "openLoopRate";
            this.openLoopRate.Size = new System.Drawing.Size(52, 20);
            this.openLoopRate.TabIndex = 2;
            this.openLoopRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Rate (Hz):";
            // 
            // openLoopVoltage1
            // 
            this.openLoopVoltage1.DecimalPlaces = 2;
            this.openLoopVoltage1.Location = new System.Drawing.Point(128, 54);
            this.openLoopVoltage1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.openLoopVoltage1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.openLoopVoltage1.Name = "openLoopVoltage1";
            this.openLoopVoltage1.Size = new System.Drawing.Size(52, 20);
            this.openLoopVoltage1.TabIndex = 3;
            this.openLoopVoltage1.Value = new decimal(new int[] {
            75,
            0,
            0,
            131072});
            this.openLoopVoltage1.ValueChanged += new System.EventHandler(this.openLoopVoltage1_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Voltage, phase 1 (V):";
            // 
            // openLoopWidth1
            // 
            this.openLoopWidth1.Location = new System.Drawing.Point(128, 106);
            this.openLoopWidth1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.openLoopWidth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.openLoopWidth1.Name = "openLoopWidth1";
            this.openLoopWidth1.Size = new System.Drawing.Size(52, 20);
            this.openLoopWidth1.TabIndex = 5;
            this.openLoopWidth1.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.openLoopWidth1.ValueChanged += new System.EventHandler(this.openLoopWidth1_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Phase 1 width (μs):";
            // 
            // openLoopStart
            // 
            this.openLoopStart.Location = new System.Drawing.Point(211, 192);
            this.openLoopStart.Name = "openLoopStart";
            this.openLoopStart.Size = new System.Drawing.Size(49, 39);
            this.openLoopStart.TabIndex = 0;
            this.openLoopStart.Text = "Start";
            this.openLoopStart.UseVisualStyleBackColor = true;
            this.openLoopStart.Click += new System.EventHandler(this.openLoopStart_Click);
            // 
            // openLoopStop
            // 
            this.openLoopStop.Enabled = false;
            this.openLoopStop.Location = new System.Drawing.Point(266, 192);
            this.openLoopStop.Name = "openLoopStop";
            this.openLoopStop.Size = new System.Drawing.Size(49, 39);
            this.openLoopStop.TabIndex = 1;
            this.openLoopStop.Text = "Stop";
            this.openLoopStop.UseVisualStyleBackColor = true;
            this.openLoopStop.Click += new System.EventHandler(this.openLoopStop_Click);
            // 
            // listBox_stimChannels
            // 
            this.listBox_stimChannels.FormattingEnabled = true;
            this.listBox_stimChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_stimChannels.Location = new System.Drawing.Point(202, 30);
            this.listBox_stimChannels.Name = "listBox_stimChannels";
            this.listBox_stimChannels.ScrollAlwaysVisible = true;
            this.listBox_stimChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_stimChannels.Size = new System.Drawing.Size(103, 108);
            this.listBox_stimChannels.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(199, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Channels to Stimulate";
            // 
            // openLoopInterphaseLength
            // 
            this.openLoopInterphaseLength.Location = new System.Drawing.Point(128, 158);
            this.openLoopInterphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopInterphaseLength.Name = "openLoopInterphaseLength";
            this.openLoopInterphaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopInterphaseLength.TabIndex = 7;
            this.openLoopInterphaseLength.ValueChanged += new System.EventHandler(this.openLoopInterphaseLength_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 160);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(112, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Interphase length (μs):";
            // 
            // openLoopVoltage2
            // 
            this.openLoopVoltage2.DecimalPlaces = 2;
            this.openLoopVoltage2.Location = new System.Drawing.Point(128, 80);
            this.openLoopVoltage2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.openLoopVoltage2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.openLoopVoltage2.Name = "openLoopVoltage2";
            this.openLoopVoltage2.Size = new System.Drawing.Size(52, 20);
            this.openLoopVoltage2.TabIndex = 4;
            this.openLoopVoltage2.Value = new decimal(new int[] {
            75,
            0,
            0,
            -2147352576});
            this.openLoopVoltage2.ValueChanged += new System.EventHandler(this.openLoopVoltage2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Voltage, phase 2 (V):";
            // 
            // openLoopWidth2
            // 
            this.openLoopWidth2.Location = new System.Drawing.Point(128, 132);
            this.openLoopWidth2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.openLoopWidth2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.openLoopWidth2.Name = "openLoopWidth2";
            this.openLoopWidth2.Size = new System.Drawing.Size(52, 20);
            this.openLoopWidth2.TabIndex = 6;
            this.openLoopWidth2.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.openLoopWidth2.ValueChanged += new System.EventHandler(this.openLoopWidth2_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Phase 2 width (μs):";
            // 
            // openLoopPrephaseLength
            // 
            this.openLoopPrephaseLength.Location = new System.Drawing.Point(128, 184);
            this.openLoopPrephaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopPrephaseLength.Name = "openLoopPrephaseLength";
            this.openLoopPrephaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopPrephaseLength.TabIndex = 8;
            this.openLoopPrephaseLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.openLoopPrephaseLength.ValueChanged += new System.EventHandler(this.openLoopPrephaseLength_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 186);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 13);
            this.label35.TabIndex = 24;
            this.label35.Text = "Pre-phase length (μs):";
            // 
            // openLoopPostphaseLength
            // 
            this.openLoopPostphaseLength.Location = new System.Drawing.Point(128, 210);
            this.openLoopPostphaseLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.openLoopPostphaseLength.Name = "openLoopPostphaseLength";
            this.openLoopPostphaseLength.Size = new System.Drawing.Size(52, 20);
            this.openLoopPostphaseLength.TabIndex = 9;
            this.openLoopPostphaseLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.openLoopPostphaseLength.ValueChanged += new System.EventHandler(this.openLoopPostphaseLength_ValueChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 212);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(115, 13);
            this.label36.TabIndex = 26;
            this.label36.Text = "Post-phase length (μs):";
            // 
            // button_openLoopSelectAll
            // 
            this.button_openLoopSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openLoopSelectAll.Location = new System.Drawing.Point(261, 146);
            this.button_openLoopSelectAll.Name = "button_openLoopSelectAll";
            this.button_openLoopSelectAll.Size = new System.Drawing.Size(35, 32);
            this.button_openLoopSelectAll.TabIndex = 11;
            this.button_openLoopSelectAll.Text = "Select All";
            this.button_openLoopSelectAll.UseVisualStyleBackColor = true;
            this.button_openLoopSelectAll.Click += new System.EventHandler(this.button_openLoopSelectAll_Click);
            // 
            // button_openLoopSelectNone
            // 
            this.button_openLoopSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openLoopSelectNone.Location = new System.Drawing.Point(220, 146);
            this.button_openLoopSelectNone.Name = "button_openLoopSelectNone";
            this.button_openLoopSelectNone.Size = new System.Drawing.Size(35, 32);
            this.button_openLoopSelectNone.TabIndex = 12;
            this.button_openLoopSelectNone.Text = "Select None";
            this.button_openLoopSelectNone.UseVisualStyleBackColor = true;
            this.button_openLoopSelectNone.Click += new System.EventHandler(this.button_openLoopSelectNone_Click);
            // 
            // waveformGraph_openLoopStimPulse
            // 
            this.waveformGraph_openLoopStimPulse.Location = new System.Drawing.Point(6, 235);
            this.waveformGraph_openLoopStimPulse.Name = "waveformGraph_openLoopStimPulse";
            this.waveformGraph_openLoopStimPulse.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph_openLoopStimPulse.Size = new System.Drawing.Size(309, 136);
            this.waveformGraph_openLoopStimPulse.TabIndex = 29;
            this.waveformGraph_openLoopStimPulse.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph_openLoopStimPulse.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Voltage (Volts)";
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time (microseconds)";
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.label65);
            this.groupBox22.Controls.Add(this.button_electrolesioningSelectNone);
            this.groupBox22.Controls.Add(this.button_electrolesioningSelectAll);
            this.groupBox22.Controls.Add(this.listBox_electrolesioningChannels);
            this.groupBox22.Controls.Add(this.label64);
            this.groupBox22.Controls.Add(this.numericUpDown_electrolesioningDuration);
            this.groupBox22.Controls.Add(this.label31);
            this.groupBox22.Controls.Add(this.numericUpDown_electrolesioningVoltage);
            this.groupBox22.Controls.Add(this.button_electrolesioningStart);
            this.groupBox22.Location = new System.Drawing.Point(745, 241);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(190, 257);
            this.groupBox22.TabIndex = 4;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Electrolesioning";
            // 
            // button_electrolesioningStart
            // 
            this.button_electrolesioningStart.Location = new System.Drawing.Point(20, 208);
            this.button_electrolesioningStart.Name = "button_electrolesioningStart";
            this.button_electrolesioningStart.Size = new System.Drawing.Size(102, 35);
            this.button_electrolesioningStart.TabIndex = 0;
            this.button_electrolesioningStart.Text = "Start Lesioning";
            this.button_electrolesioningStart.UseVisualStyleBackColor = true;
            this.button_electrolesioningStart.Click += new System.EventHandler(this.button_electrolesioningStart_Click);
            // 
            // numericUpDown_electrolesioningVoltage
            // 
            this.numericUpDown_electrolesioningVoltage.DecimalPlaces = 2;
            this.numericUpDown_electrolesioningVoltage.Location = new System.Drawing.Point(74, 19);
            this.numericUpDown_electrolesioningVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_electrolesioningVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_electrolesioningVoltage.Name = "numericUpDown_electrolesioningVoltage";
            this.numericUpDown_electrolesioningVoltage.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_electrolesioningVoltage.TabIndex = 1;
            this.numericUpDown_electrolesioningVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Voltage (V):";
            // 
            // numericUpDown_electrolesioningDuration
            // 
            this.numericUpDown_electrolesioningDuration.Location = new System.Drawing.Point(74, 45);
            this.numericUpDown_electrolesioningDuration.Name = "numericUpDown_electrolesioningDuration";
            this.numericUpDown_electrolesioningDuration.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_electrolesioningDuration.TabIndex = 2;
            this.numericUpDown_electrolesioningDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 47);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(64, 13);
            this.label64.TabIndex = 4;
            this.label64.Text = "Duration (s):";
            // 
            // listBox_electrolesioningChannels
            // 
            this.listBox_electrolesioningChannels.FormattingEnabled = true;
            this.listBox_electrolesioningChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.listBox_electrolesioningChannels.Location = new System.Drawing.Point(12, 96);
            this.listBox_electrolesioningChannels.Name = "listBox_electrolesioningChannels";
            this.listBox_electrolesioningChannels.ScrollAlwaysVisible = true;
            this.listBox_electrolesioningChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_electrolesioningChannels.Size = new System.Drawing.Size(65, 95);
            this.listBox_electrolesioningChannels.TabIndex = 3;
            // 
            // button_electrolesioningSelectAll
            // 
            this.button_electrolesioningSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_electrolesioningSelectAll.Location = new System.Drawing.Point(88, 106);
            this.button_electrolesioningSelectAll.Name = "button_electrolesioningSelectAll";
            this.button_electrolesioningSelectAll.Size = new System.Drawing.Size(35, 31);
            this.button_electrolesioningSelectAll.TabIndex = 4;
            this.button_electrolesioningSelectAll.Text = "Select All";
            this.button_electrolesioningSelectAll.UseVisualStyleBackColor = true;
            this.button_electrolesioningSelectAll.Click += new System.EventHandler(this.button_electrolesioningSelectAll_Click);
            // 
            // button_electrolesioningSelectNone
            // 
            this.button_electrolesioningSelectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_electrolesioningSelectNone.Location = new System.Drawing.Point(88, 153);
            this.button_electrolesioningSelectNone.Name = "button_electrolesioningSelectNone";
            this.button_electrolesioningSelectNone.Size = new System.Drawing.Size(35, 31);
            this.button_electrolesioningSelectNone.TabIndex = 5;
            this.button_electrolesioningSelectNone.Text = "Select None";
            this.button_electrolesioningSelectNone.UseVisualStyleBackColor = true;
            this.button_electrolesioningSelectNone.Click += new System.EventHandler(this.button_electrolesioningSelectNone_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(9, 80);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(109, 13);
            this.label65.TabIndex = 21;
            this.label65.Text = "Channels to Stimulate";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.button_IISZapper_stop);
            this.groupBox23.Controls.Add(this.button_IISZapper_start);
            this.groupBox23.Controls.Add(this.label66);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_channel);
            this.groupBox23.Controls.Add(this.label67);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_phaseWidth);
            this.groupBox23.Controls.Add(this.label68);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_rate);
            this.groupBox23.Controls.Add(this.label69);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_voltage);
            this.groupBox23.Controls.Add(this.label70);
            this.groupBox23.Controls.Add(this.numericUpDown_IISZapper_pulsePerTrain);
            this.groupBox23.Location = new System.Drawing.Point(745, 11);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(190, 227);
            this.groupBox23.TabIndex = 5;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "IIS Zapper (Experimental)";
            this.groupBox23.Visible = false;
            // 
            // numericUpDown_IISZapper_pulsePerTrain
            // 
            this.numericUpDown_IISZapper_pulsePerTrain.Location = new System.Drawing.Point(106, 22);
            this.numericUpDown_IISZapper_pulsePerTrain.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_pulsePerTrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_pulsePerTrain.Name = "numericUpDown_IISZapper_pulsePerTrain";
            this.numericUpDown_IISZapper_pulsePerTrain.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_pulsePerTrain.TabIndex = 2;
            this.numericUpDown_IISZapper_pulsePerTrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 24);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(66, 13);
            this.label70.TabIndex = 13;
            this.label70.Text = "Pulses/train:";
            // 
            // numericUpDown_IISZapper_voltage
            // 
            this.numericUpDown_IISZapper_voltage.DecimalPlaces = 1;
            this.numericUpDown_IISZapper_voltage.Location = new System.Drawing.Point(106, 48);
            this.numericUpDown_IISZapper_voltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_voltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_IISZapper_voltage.Name = "numericUpDown_IISZapper_voltage";
            this.numericUpDown_IISZapper_voltage.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_voltage.TabIndex = 3;
            this.numericUpDown_IISZapper_voltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 50);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(62, 13);
            this.label69.TabIndex = 16;
            this.label69.Text = "Voltage (V):";
            // 
            // numericUpDown_IISZapper_rate
            // 
            this.numericUpDown_IISZapper_rate.DecimalPlaces = 2;
            this.numericUpDown_IISZapper_rate.Location = new System.Drawing.Point(106, 74);
            this.numericUpDown_IISZapper_rate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IISZapper_rate.Name = "numericUpDown_IISZapper_rate";
            this.numericUpDown_IISZapper_rate.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_rate.TabIndex = 4;
            this.numericUpDown_IISZapper_rate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 76);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(55, 13);
            this.label68.TabIndex = 18;
            this.label68.Text = "Rate (Hz):";
            // 
            // numericUpDown_IISZapper_phaseWidth
            // 
            this.numericUpDown_IISZapper_phaseWidth.Location = new System.Drawing.Point(106, 100);
            this.numericUpDown_IISZapper_phaseWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_phaseWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_phaseWidth.Name = "numericUpDown_IISZapper_phaseWidth";
            this.numericUpDown_IISZapper_phaseWidth.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_phaseWidth.TabIndex = 5;
            this.numericUpDown_IISZapper_phaseWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 102);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(88, 13);
            this.label67.TabIndex = 19;
            this.label67.Text = "Phase width (μs):";
            // 
            // numericUpDown_IISZapper_channel
            // 
            this.numericUpDown_IISZapper_channel.Location = new System.Drawing.Point(106, 126);
            this.numericUpDown_IISZapper_channel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_channel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_IISZapper_channel.Name = "numericUpDown_IISZapper_channel";
            this.numericUpDown_IISZapper_channel.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_IISZapper_channel.TabIndex = 6;
            this.numericUpDown_IISZapper_channel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 133);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(49, 13);
            this.label66.TabIndex = 20;
            this.label66.Text = "Channel:";
            // 
            // button_IISZapper_start
            // 
            this.button_IISZapper_start.Location = new System.Drawing.Point(20, 154);
            this.button_IISZapper_start.Name = "button_IISZapper_start";
            this.button_IISZapper_start.Size = new System.Drawing.Size(54, 36);
            this.button_IISZapper_start.TabIndex = 0;
            this.button_IISZapper_start.Text = "Start";
            this.button_IISZapper_start.UseVisualStyleBackColor = true;
            this.button_IISZapper_start.Click += new System.EventHandler(this.button_IISZapper_start_Click);
            // 
            // button_IISZapper_stop
            // 
            this.button_IISZapper_stop.Enabled = false;
            this.button_IISZapper_stop.Location = new System.Drawing.Point(82, 154);
            this.button_IISZapper_stop.Name = "button_IISZapper_stop";
            this.button_IISZapper_stop.Size = new System.Drawing.Size(56, 36);
            this.button_IISZapper_stop.TabIndex = 1;
            this.button_IISZapper_stop.Text = "Stop";
            this.button_IISZapper_stop.UseVisualStyleBackColor = true;
            this.button_IISZapper_stop.Click += new System.EventHandler(this.button_IISZapper_stop_Click);
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.groupBox18);
            this.groupBox24.Controls.Add(this.offsetVoltage);
            this.groupBox24.Controls.Add(this.label26);
            this.groupBox24.Location = new System.Drawing.Point(8, 8);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(321, 68);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Global Parameters";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(189, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Offset Voltage (V)";
            // 
            // offsetVoltage
            // 
            this.offsetVoltage.DecimalPlaces = 3;
            this.offsetVoltage.Location = new System.Drawing.Point(192, 32);
            this.offsetVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.offsetVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.offsetVoltage.Name = "offsetVoltage";
            this.offsetVoltage.Size = new System.Drawing.Size(110, 20);
            this.offsetVoltage.TabIndex = 1;
            this.offsetVoltage.ValueChanged += new System.EventHandler(this.offsetVoltage_ValueChanged);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.radioButton_stimVoltageControlled);
            this.groupBox18.Controls.Add(this.radioButton_stimCurrentControlled);
            this.groupBox18.Location = new System.Drawing.Point(9, 19);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(158, 39);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Current vs. Voltage Control";
            // 
            // radioButton_stimCurrentControlled
            // 
            this.radioButton_stimCurrentControlled.AutoSize = true;
            this.radioButton_stimCurrentControlled.Checked = true;
            this.radioButton_stimCurrentControlled.Location = new System.Drawing.Point(6, 16);
            this.radioButton_stimCurrentControlled.Name = "radioButton_stimCurrentControlled";
            this.radioButton_stimCurrentControlled.Size = new System.Drawing.Size(59, 17);
            this.radioButton_stimCurrentControlled.TabIndex = 0;
            this.radioButton_stimCurrentControlled.TabStop = true;
            this.radioButton_stimCurrentControlled.Text = "Current";
            this.radioButton_stimCurrentControlled.UseVisualStyleBackColor = true;
            this.radioButton_stimCurrentControlled.Click += new System.EventHandler(this.radioButton_stimCurrentControlled_Click);
            // 
            // radioButton_stimVoltageControlled
            // 
            this.radioButton_stimVoltageControlled.AutoSize = true;
            this.radioButton_stimVoltageControlled.Location = new System.Drawing.Point(91, 16);
            this.radioButton_stimVoltageControlled.Name = "radioButton_stimVoltageControlled";
            this.radioButton_stimVoltageControlled.Size = new System.Drawing.Size(61, 17);
            this.radioButton_stimVoltageControlled.TabIndex = 1;
            this.radioButton_stimVoltageControlled.Text = "Voltage";
            this.radioButton_stimVoltageControlled.UseVisualStyleBackColor = true;
            this.radioButton_stimVoltageControlled.Click += new System.EventHandler(this.radioButton_stimVoltageControlled_Click);
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.groupBox34);
            this.groupBox30.Controls.Add(this.button_browseAuxFile);
            this.groupBox30.Controls.Add(this.textBox_AuxFile);
            this.groupBox30.Controls.Add(this.label62);
            this.groupBox30.Controls.Add(this.checkBox_useManStimWaveform);
            this.groupBox30.Controls.Add(this.button_BrowseOLDFile);
            this.groupBox30.Controls.Add(this.textBox_digitalProtocolFileLocation);
            this.groupBox30.Controls.Add(this.label61);
            this.groupBox30.Controls.Add(this.button_BrowseOLStimFile);
            this.groupBox30.Controls.Add(this.button_stopStimFromFile);
            this.groupBox30.Controls.Add(this.textBox_protocolFileLocations);
            this.groupBox30.Controls.Add(this.label85);
            this.groupBox30.Controls.Add(this.button_startStimFromFile);
            this.groupBox30.Location = new System.Drawing.Point(340, 8);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(399, 227);
            this.groupBox30.TabIndex = 12;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Open Loop Experiment (Experimental)";
            // 
            // button_startStimFromFile
            // 
            this.button_startStimFromFile.Location = new System.Drawing.Point(227, 184);
            this.button_startStimFromFile.Name = "button_startStimFromFile";
            this.button_startStimFromFile.Size = new System.Drawing.Size(75, 27);
            this.button_startStimFromFile.TabIndex = 0;
            this.button_startStimFromFile.Text = "Start";
            this.button_startStimFromFile.UseVisualStyleBackColor = true;
            this.button_startStimFromFile.Click += new System.EventHandler(this.button_startStimFromFile_Click);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 25);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(166, 13);
            this.label85.TabIndex = 2;
            this.label85.Text = "Open-loop stimulation file (*.olstim)";
            // 
            // textBox_protocolFileLocations
            // 
            this.textBox_protocolFileLocations.Location = new System.Drawing.Point(180, 21);
            this.textBox_protocolFileLocations.Name = "textBox_protocolFileLocations";
            this.textBox_protocolFileLocations.Size = new System.Drawing.Size(175, 20);
            this.textBox_protocolFileLocations.TabIndex = 5;
            // 
            // button_stopStimFromFile
            // 
            this.button_stopStimFromFile.Enabled = false;
            this.button_stopStimFromFile.Location = new System.Drawing.Point(318, 184);
            this.button_stopStimFromFile.Name = "button_stopStimFromFile";
            this.button_stopStimFromFile.Size = new System.Drawing.Size(75, 27);
            this.button_stopStimFromFile.TabIndex = 6;
            this.button_stopStimFromFile.Text = "Stop";
            this.button_stopStimFromFile.UseVisualStyleBackColor = true;
            this.button_stopStimFromFile.Click += new System.EventHandler(this.button_stopStimFromFile_Click);
            // 
            // button_BrowseOLStimFile
            // 
            this.button_BrowseOLStimFile.Location = new System.Drawing.Point(368, 20);
            this.button_BrowseOLStimFile.Name = "button_BrowseOLStimFile";
            this.button_BrowseOLStimFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOLStimFile.TabIndex = 36;
            this.button_BrowseOLStimFile.Text = "...";
            this.button_BrowseOLStimFile.UseVisualStyleBackColor = true;
            this.button_BrowseOLStimFile.Click += new System.EventHandler(this.button_BrowseOLStimFile_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 85);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(140, 13);
            this.label61.TabIndex = 38;
            this.label61.Text = "Open-loop digital file (*.oldig)";
            // 
            // textBox_digitalProtocolFileLocation
            // 
            this.textBox_digitalProtocolFileLocation.Location = new System.Drawing.Point(180, 81);
            this.textBox_digitalProtocolFileLocation.Name = "textBox_digitalProtocolFileLocation";
            this.textBox_digitalProtocolFileLocation.Size = new System.Drawing.Size(175, 20);
            this.textBox_digitalProtocolFileLocation.TabIndex = 39;
            // 
            // button_BrowseOLDFile
            // 
            this.button_BrowseOLDFile.Location = new System.Drawing.Point(368, 80);
            this.button_BrowseOLDFile.Name = "button_BrowseOLDFile";
            this.button_BrowseOLDFile.Size = new System.Drawing.Size(25, 23);
            this.button_BrowseOLDFile.TabIndex = 40;
            this.button_BrowseOLDFile.Text = "...";
            this.button_BrowseOLDFile.UseVisualStyleBackColor = true;
            this.button_BrowseOLDFile.Click += new System.EventHandler(this.button_BrowseOLDFile_Click);
            // 
            // checkBox_useManStimWaveform
            // 
            this.checkBox_useManStimWaveform.AutoSize = true;
            this.checkBox_useManStimWaveform.Location = new System.Drawing.Point(9, 182);
            this.checkBox_useManStimWaveform.Name = "checkBox_useManStimWaveform";
            this.checkBox_useManStimWaveform.Size = new System.Drawing.Size(208, 30);
            this.checkBox_useManStimWaveform.TabIndex = 41;
            this.checkBox_useManStimWaveform.Text = "Use pre-defined stimulation waveform?\r\n(as defined in the Manual Stim. Box)";
            this.checkBox_useManStimWaveform.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 55);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(153, 13);
            this.label62.TabIndex = 43;
            this.label62.Text = "Open-loop auxiliary file (*.olaux)";
            // 
            // textBox_AuxFile
            // 
            this.textBox_AuxFile.Location = new System.Drawing.Point(180, 51);
            this.textBox_AuxFile.Name = "textBox_AuxFile";
            this.textBox_AuxFile.Size = new System.Drawing.Size(175, 20);
            this.textBox_AuxFile.TabIndex = 44;
            // 
            // button_browseAuxFile
            // 
            this.button_browseAuxFile.Location = new System.Drawing.Point(368, 50);
            this.button_browseAuxFile.Name = "button_browseAuxFile";
            this.button_browseAuxFile.Size = new System.Drawing.Size(25, 23);
            this.button_browseAuxFile.TabIndex = 45;
            this.button_browseAuxFile.Text = "...";
            this.button_browseAuxFile.UseVisualStyleBackColor = true;
            this.button_browseAuxFile.Click += new System.EventHandler(this.button_browseAuxFile_Click);
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.label11);
            this.groupBox34.Controls.Add(this.numericUpDown_NumberOfOpenLoopRepeats);
            this.groupBox34.Controls.Add(this.checkBox_RepeatOpenLoopProtocol);
            this.groupBox34.Location = new System.Drawing.Point(9, 109);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(384, 42);
            this.groupBox34.TabIndex = 49;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "     Repeat Protocol?";
            // 
            // checkBox_RepeatOpenLoopProtocol
            // 
            this.checkBox_RepeatOpenLoopProtocol.AutoSize = true;
            this.checkBox_RepeatOpenLoopProtocol.Location = new System.Drawing.Point(6, 0);
            this.checkBox_RepeatOpenLoopProtocol.Name = "checkBox_RepeatOpenLoopProtocol";
            this.checkBox_RepeatOpenLoopProtocol.Size = new System.Drawing.Size(15, 14);
            this.checkBox_RepeatOpenLoopProtocol.TabIndex = 46;
            this.checkBox_RepeatOpenLoopProtocol.UseVisualStyleBackColor = true;
            this.checkBox_RepeatOpenLoopProtocol.CheckedChanged += new System.EventHandler(this.checkBox_RepeatOpenLoopProtocol_CheckedChanged);
            // 
            // numericUpDown_NumberOfOpenLoopRepeats
            // 
            this.numericUpDown_NumberOfOpenLoopRepeats.Location = new System.Drawing.Point(240, 14);
            this.numericUpDown_NumberOfOpenLoopRepeats.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_NumberOfOpenLoopRepeats.Name = "numericUpDown_NumberOfOpenLoopRepeats";
            this.numericUpDown_NumberOfOpenLoopRepeats.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown_NumberOfOpenLoopRepeats.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Number of Repeats (0 = continuous)";
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.comboBox_closedLoopProtocol);
            this.groupBox35.Controls.Add(this.label63);
            this.groupBox35.Controls.Add(this.checkBox_useManStimWaveformCL);
            this.groupBox35.Controls.Add(this.label12);
            this.groupBox35.Controls.Add(this.button_browseCLStimFiles);
            this.groupBox35.Controls.Add(this.button_stopClosedLoopStim);
            this.groupBox35.Controls.Add(this.textBox_ClosedLoopProtocolFile);
            this.groupBox35.Controls.Add(this.button_startClosedLoopStim);
            this.groupBox35.Location = new System.Drawing.Point(340, 241);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(399, 155);
            this.groupBox35.TabIndex = 13;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Closed Loop Experiment (Experimental)";
            // 
            // button_startClosedLoopStim
            // 
            this.button_startClosedLoopStim.Location = new System.Drawing.Point(227, 116);
            this.button_startClosedLoopStim.Name = "button_startClosedLoopStim";
            this.button_startClosedLoopStim.Size = new System.Drawing.Size(75, 27);
            this.button_startClosedLoopStim.TabIndex = 7;
            this.button_startClosedLoopStim.Text = "Start";
            this.button_startClosedLoopStim.UseVisualStyleBackColor = true;
            this.button_startClosedLoopStim.Click += new System.EventHandler(this.button_startClosedLoopStim_Click);
            // 
            // textBox_ClosedLoopProtocolFile
            // 
            this.textBox_ClosedLoopProtocolFile.Location = new System.Drawing.Point(169, 25);
            this.textBox_ClosedLoopProtocolFile.Name = "textBox_ClosedLoopProtocolFile";
            this.textBox_ClosedLoopProtocolFile.Size = new System.Drawing.Size(186, 20);
            this.textBox_ClosedLoopProtocolFile.TabIndex = 50;
            // 
            // button_stopClosedLoopStim
            // 
            this.button_stopClosedLoopStim.Enabled = false;
            this.button_stopClosedLoopStim.Location = new System.Drawing.Point(318, 116);
            this.button_stopClosedLoopStim.Name = "button_stopClosedLoopStim";
            this.button_stopClosedLoopStim.Size = new System.Drawing.Size(75, 27);
            this.button_stopClosedLoopStim.TabIndex = 8;
            this.button_stopClosedLoopStim.Text = "Stop";
            this.button_stopClosedLoopStim.UseVisualStyleBackColor = true;
            this.button_stopClosedLoopStim.Click += new System.EventHandler(this.button_stopClosedLoopStim_Click);
            // 
            // button_browseCLStimFiles
            // 
            this.button_browseCLStimFiles.Location = new System.Drawing.Point(368, 24);
            this.button_browseCLStimFiles.Name = "button_browseCLStimFiles";
            this.button_browseCLStimFiles.Size = new System.Drawing.Size(25, 23);
            this.button_browseCLStimFiles.TabIndex = 51;
            this.button_browseCLStimFiles.Text = "...";
            this.button_browseCLStimFiles.UseVisualStyleBackColor = true;
            this.button_browseCLStimFiles.Click += new System.EventHandler(this.button_BrowseCLStimFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Closed-loop protocol library (*.dll)";
            // 
            // checkBox_useManStimWaveformCL
            // 
            this.checkBox_useManStimWaveformCL.AutoSize = true;
            this.checkBox_useManStimWaveformCL.Location = new System.Drawing.Point(6, 114);
            this.checkBox_useManStimWaveformCL.Name = "checkBox_useManStimWaveformCL";
            this.checkBox_useManStimWaveformCL.Size = new System.Drawing.Size(208, 30);
            this.checkBox_useManStimWaveformCL.TabIndex = 53;
            this.checkBox_useManStimWaveformCL.Text = "Use pre-defined stimulation waveform?\r\n(as defined in the Manual Stim. Box)";
            this.checkBox_useManStimWaveformCL.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 58);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(78, 13);
            this.label63.TabIndex = 54;
            this.label63.Text = "Protocol to use";
            // 
            // comboBox_closedLoopProtocol
            // 
            this.comboBox_closedLoopProtocol.Enabled = false;
            this.comboBox_closedLoopProtocol.FormattingEnabled = true;
            this.comboBox_closedLoopProtocol.Items.AddRange(new object[] {
            "library not loaded"});
            this.comboBox_closedLoopProtocol.Location = new System.Drawing.Point(89, 55);
            this.comboBox_closedLoopProtocol.Name = "comboBox_closedLoopProtocol";
            this.comboBox_closedLoopProtocol.Size = new System.Drawing.Size(304, 21);
            this.comboBox_closedLoopProtocol.TabIndex = 55;
            // 
            // tabPage_EEG
            // 
            this.tabPage_EEG.Location = new System.Drawing.Point(4, 22);
            this.tabPage_EEG.Name = "tabPage_EEG";
            this.tabPage_EEG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EEG.Size = new System.Drawing.Size(942, 780);
            this.tabPage_EEG.TabIndex = 7;
            this.tabPage_EEG.Text = "EEG";
            this.tabPage_EEG.UseVisualStyleBackColor = true;
            // 
            // tabPage_MUA
            // 
            this.tabPage_MUA.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MUA.Name = "tabPage_MUA";
            this.tabPage_MUA.Size = new System.Drawing.Size(942, 780);
            this.tabPage_MUA.TabIndex = 8;
            this.tabPage_MUA.Text = "MUA";
            this.tabPage_MUA.UseVisualStyleBackColor = true;
            // 
            // tabPage_LFPs
            // 
            this.tabPage_LFPs.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LFPs.Name = "tabPage_LFPs";
            this.tabPage_LFPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LFPs.Size = new System.Drawing.Size(942, 780);
            this.tabPage_LFPs.TabIndex = 1;
            this.tabPage_LFPs.Text = "LFPs";
            this.tabPage_LFPs.UseVisualStyleBackColor = true;
            // 
            // tabPage_AuxInput
            // 
            this.tabPage_AuxInput.Controls.Add(this.groupBox28);
            this.tabPage_AuxInput.Controls.Add(this.groupBox33);
            this.tabPage_AuxInput.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AuxInput.Name = "tabPage_AuxInput";
            this.tabPage_AuxInput.Size = new System.Drawing.Size(942, 780);
            this.tabPage_AuxInput.TabIndex = 9;
            this.tabPage_AuxInput.Text = "Aux Input";
            this.tabPage_AuxInput.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.slide_AuxShift);
            this.groupBox33.Controls.Add(this.checkBox_FreezeAuxPlot);
            this.groupBox33.Controls.Add(this.slide_AnalogDispWidth);
            this.groupBox33.Controls.Add(this.slide_AnalogDispMaxVoltage);
            this.groupBox33.Controls.Add(this.scatterGraph_AuxAnalogData);
            this.groupBox33.Location = new System.Drawing.Point(8, 75);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(913, 701);
            this.groupBox33.TabIndex = 3;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Auxiliary Analog Input";
            // 
            // scatterGraph_AuxAnalogData
            // 
            this.scatterGraph_AuxAnalogData.Location = new System.Drawing.Point(7, 112);
            this.scatterGraph_AuxAnalogData.Name = "scatterGraph_AuxAnalogData";
            this.scatterGraph_AuxAnalogData.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot3});
            this.scatterGraph_AuxAnalogData.Size = new System.Drawing.Size(900, 579);
            this.scatterGraph_AuxAnalogData.TabIndex = 0;
            this.toolTip_outputFilename.SetToolTip(this.scatterGraph_AuxAnalogData, "Shows channels of auxiliary data. Fixed at 500 point\r\nwidth  and maximal update p" +
        "eriod of 250 regardless\r\nof input settings.");
            this.scatterGraph_AuxAnalogData.UseColorGenerator = true;
            this.scatterGraph_AuxAnalogData.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis5});
            this.scatterGraph_AuxAnalogData.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis5});
            // 
            // yAxis5
            // 
            this.yAxis5.Range = new NationalInstruments.UI.Range(-10D, 10D);
            // 
            // scatterPlot3
            // 
            this.scatterPlot3.ToolTipsEnabled = true;
            this.scatterPlot3.XAxis = this.xAxis5;
            this.scatterPlot3.YAxis = this.yAxis5;
            // 
            // slide_AnalogDispMaxVoltage
            // 
            this.slide_AnalogDispMaxVoltage.Border = NationalInstruments.UI.Border.Solid;
            this.slide_AnalogDispMaxVoltage.Caption = "Y Scale";
            this.slide_AnalogDispMaxVoltage.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slide_AnalogDispMaxVoltage.CaptionForeColor = System.Drawing.Color.Lime;
            this.slide_AnalogDispMaxVoltage.FillBackColor = System.Drawing.SystemColors.Highlight;
            this.slide_AnalogDispMaxVoltage.Location = new System.Drawing.Point(314, 24);
            this.slide_AnalogDispMaxVoltage.Name = "slide_AnalogDispMaxVoltage";
            this.slide_AnalogDispMaxVoltage.PointerColor = System.Drawing.SystemColors.ActiveBorder;
            this.slide_AnalogDispMaxVoltage.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.slide_AnalogDispMaxVoltage.Size = new System.Drawing.Size(286, 67);
            this.slide_AnalogDispMaxVoltage.TabIndex = 20;
            this.toolTip_outputFilename.SetToolTip(this.slide_AnalogDispMaxVoltage, "Change the range of the ordinate axis.");
            // 
            // slide_AnalogDispWidth
            // 
            this.slide_AnalogDispWidth.Border = NationalInstruments.UI.Border.Solid;
            this.slide_AnalogDispWidth.Caption = "Plot Width";
            this.slide_AnalogDispWidth.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slide_AnalogDispWidth.CaptionForeColor = System.Drawing.Color.Lime;
            this.slide_AnalogDispWidth.FillBackColor = System.Drawing.SystemColors.Highlight;
            this.slide_AnalogDispWidth.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.slide_AnalogDispWidth.FillStyle = NationalInstruments.UI.FillStyle.None;
            this.slide_AnalogDispWidth.Location = new System.Drawing.Point(7, 24);
            this.slide_AnalogDispWidth.Name = "slide_AnalogDispWidth";
            this.slide_AnalogDispWidth.PointerColor = System.Drawing.SystemColors.ActiveBorder;
            this.slide_AnalogDispWidth.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.slide_AnalogDispWidth.Size = new System.Drawing.Size(286, 67);
            this.slide_AnalogDispWidth.TabIndex = 21;
            this.toolTip_outputFilename.SetToolTip(this.slide_AnalogDispWidth, "Change the width of the abscissa");
            // 
            // checkBox_FreezeAuxPlot
            // 
            this.checkBox_FreezeAuxPlot.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_FreezeAuxPlot.AutoSize = true;
            this.checkBox_FreezeAuxPlot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_FreezeAuxPlot.Location = new System.Drawing.Point(836, 130);
            this.checkBox_FreezeAuxPlot.Name = "checkBox_FreezeAuxPlot";
            this.checkBox_FreezeAuxPlot.Size = new System.Drawing.Size(49, 23);
            this.checkBox_FreezeAuxPlot.TabIndex = 22;
            this.checkBox_FreezeAuxPlot.Text = "Freeze";
            this.toolTip_outputFilename.SetToolTip(this.checkBox_FreezeAuxPlot, "Freeze display");
            this.checkBox_FreezeAuxPlot.UseVisualStyleBackColor = true;
            // 
            // slide_AuxShift
            // 
            this.slide_AuxShift.Border = NationalInstruments.UI.Border.Solid;
            this.slide_AuxShift.Caption = "Y Shift";
            this.slide_AuxShift.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slide_AuxShift.CaptionForeColor = System.Drawing.Color.Lime;
            this.slide_AuxShift.FillBackColor = System.Drawing.SystemColors.Highlight;
            this.slide_AuxShift.Location = new System.Drawing.Point(621, 24);
            this.slide_AuxShift.Name = "slide_AuxShift";
            this.slide_AuxShift.PointerColor = System.Drawing.SystemColors.ActiveBorder;
            this.slide_AuxShift.Range = new NationalInstruments.UI.Range(-10D, 10D);
            this.slide_AuxShift.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.slide_AuxShift.Size = new System.Drawing.Size(286, 67);
            this.slide_AuxShift.TabIndex = 23;
            this.toolTip_outputFilename.SetToolTip(this.slide_AuxShift, "Shift the plot up and down");
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.ledArray_DigitalState);
            this.groupBox28.Location = new System.Drawing.Point(8, 3);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(913, 64);
            this.groupBox28.TabIndex = 2;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Digital Input";
            this.toolTip_outputFilename.SetToolTip(this.groupBox28, "Displays input port state. Update time may be too slow\r\nto show all state changes" +
        ".");
            // 
            // ledArray_DigitalState
            // 
            // 
            // 
            // 
            this.ledArray_DigitalState.ItemTemplate.LedStyle = NationalInstruments.UI.LedStyle.Square;
            this.ledArray_DigitalState.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.ledArray_DigitalState.ItemTemplate.Name = "";
            this.ledArray_DigitalState.ItemTemplate.OffColor = System.Drawing.Color.Black;
            this.ledArray_DigitalState.ItemTemplate.OnColor = System.Drawing.Color.Red;
            this.ledArray_DigitalState.ItemTemplate.Size = new System.Drawing.Size(27, 27);
            this.ledArray_DigitalState.ItemTemplate.TabIndex = 0;
            this.ledArray_DigitalState.ItemTemplate.TabStop = false;
            this.ledArray_DigitalState.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal;
            this.ledArray_DigitalState.Location = new System.Drawing.Point(3, 10);
            this.ledArray_DigitalState.Name = "ledArray_DigitalState";
            this.ledArray_DigitalState.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(32);
            this.ledArray_DigitalState.Size = new System.Drawing.Size(904, 49);
            this.ledArray_DigitalState.TabIndex = 0;
            // 
            // tabPage_waveforms
            // 
            this.tabPage_waveforms.Controls.Add(this.panel3);
            this.tabPage_waveforms.Location = new System.Drawing.Point(4, 22);
            this.tabPage_waveforms.Name = "tabPage_waveforms";
            this.tabPage_waveforms.Size = new System.Drawing.Size(942, 780);
            this.tabPage_waveforms.TabIndex = 2;
            this.tabPage_waveforms.Text = "Spk Wfms";
            this.tabPage_waveforms.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button_clearSpkWfms);
            this.panel3.Controls.Add(this.numericUpDown_NumSnipsDisplayed);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 749);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 31);
            this.panel3.TabIndex = 2;
            // 
            // numericUpDown_NumSnipsDisplayed
            // 
            this.numericUpDown_NumSnipsDisplayed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_NumSnipsDisplayed.Location = new System.Drawing.Point(151, 8);
            this.numericUpDown_NumSnipsDisplayed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_NumSnipsDisplayed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumSnipsDisplayed.Name = "numericUpDown_NumSnipsDisplayed";
            this.numericUpDown_NumSnipsDisplayed.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_NumSnipsDisplayed.TabIndex = 21;
            this.numericUpDown_NumSnipsDisplayed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_NumSnipsDisplayed.ValueChanged += new System.EventHandler(this.numericUpDown_NumSnipsDisplayed_ValueChanged);
            // 
            // button_clearSpkWfms
            // 
            this.button_clearSpkWfms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearSpkWfms.Location = new System.Drawing.Point(826, 5);
            this.button_clearSpkWfms.Name = "button_clearSpkWfms";
            this.button_clearSpkWfms.Size = new System.Drawing.Size(111, 23);
            this.button_clearSpkWfms.TabIndex = 1;
            this.button_clearSpkWfms.TabStop = false;
            this.button_clearSpkWfms.Text = "Clear Waveforms";
            this.button_clearSpkWfms.UseVisualStyleBackColor = true;
            this.button_clearSpkWfms.Click += new System.EventHandler(this.button_clearSpkWfms_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 10);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "# Spike Snippets Displayed";
            // 
            // tabPage_spikes
            // 
            this.tabPage_spikes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_spikes.Name = "tabPage_spikes";
            this.tabPage_spikes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_spikes.Size = new System.Drawing.Size(942, 780);
            this.tabPage_spikes.TabIndex = 0;
            this.tabPage_spikes.Text = "Spikes";
            this.tabPage_spikes.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_spikes);
            this.tabControl.Controls.Add(this.tabPage_waveforms);
            this.tabControl.Controls.Add(this.tabPage_AuxInput);
            this.tabControl.Controls.Add(this.tabPage_LFPs);
            this.tabControl.Controls.Add(this.tabPage_MUA);
            this.tabControl.Controls.Add(this.tabPage_EEG);
            this.tabControl.Controls.Add(this.tabPage_stim);
            this.tabControl.Controls.Add(this.tabPage_impedance);
            this.tabControl.Controls.Add(this.tabPage_ProgRef);
            this.tabControl.Controls.Add(this.tabPage_diagnostics);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 806);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // button_computeGain
            // 
            this.button_computeGain.Location = new System.Drawing.Point(798, 283);
            this.button_computeGain.Name = "button_computeGain";
            this.button_computeGain.Size = new System.Drawing.Size(75, 23);
            this.button_computeGain.TabIndex = 0;
            this.button_computeGain.Text = "Start";
            this.button_computeGain.UseVisualStyleBackColor = true;
            this.button_computeGain.Click += new System.EventHandler(this.button_computeGain_Click);
            // 
            // numericUpDown_stopFreq
            // 
            this.numericUpDown_stopFreq.DecimalPlaces = 1;
            this.numericUpDown_stopFreq.Location = new System.Drawing.Point(753, 64);
            this.numericUpDown_stopFreq.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stopFreq.Name = "numericUpDown_stopFreq";
            this.numericUpDown_stopFreq.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_stopFreq.TabIndex = 2;
            this.numericUpDown_stopFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown_startFreq
            // 
            this.numericUpDown_startFreq.DecimalPlaces = 1;
            this.numericUpDown_startFreq.Location = new System.Drawing.Point(753, 38);
            this.numericUpDown_startFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_startFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_startFreq.Name = "numericUpDown_startFreq";
            this.numericUpDown_startFreq.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_startFreq.TabIndex = 1;
            this.numericUpDown_startFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(640, 40);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 13);
            this.label39.TabIndex = 7;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(640, 66);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(0, 13);
            this.label40.TabIndex = 8;
            // 
            // numericUpDown_diagnosticsVoltage
            // 
            this.numericUpDown_diagnosticsVoltage.DecimalPlaces = 3;
            this.numericUpDown_diagnosticsVoltage.Location = new System.Drawing.Point(753, 116);
            this.numericUpDown_diagnosticsVoltage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_diagnosticsVoltage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_diagnosticsVoltage.Name = "numericUpDown_diagnosticsVoltage";
            this.numericUpDown_diagnosticsVoltage.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_diagnosticsVoltage.TabIndex = 4;
            this.numericUpDown_diagnosticsVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(640, 118);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 13);
            this.label41.TabIndex = 10;
            // 
            // numericUpDown_numPeriods
            // 
            this.numericUpDown_numPeriods.DecimalPlaces = 1;
            this.numericUpDown_numPeriods.Location = new System.Drawing.Point(753, 142);
            this.numericUpDown_numPeriods.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numPeriods.Name = "numericUpDown_numPeriods";
            this.numericUpDown_numPeriods.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numPeriods.TabIndex = 5;
            this.numericUpDown_numPeriods.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(640, 144);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 13);
            this.label42.TabIndex = 12;
            // 
            // checkBox_diagnosticsBulk
            // 
            this.checkBox_diagnosticsBulk.AutoSize = true;
            this.checkBox_diagnosticsBulk.Location = new System.Drawing.Point(643, 177);
            this.checkBox_diagnosticsBulk.Name = "checkBox_diagnosticsBulk";
            this.checkBox_diagnosticsBulk.Size = new System.Drawing.Size(257, 17);
            this.checkBox_diagnosticsBulk.TabIndex = 6;
            this.checkBox_diagnosticsBulk.Text = "All channels at once (requires special hardware)?";
            this.checkBox_diagnosticsBulk.UseVisualStyleBackColor = true;
            // 
            // checkBox_diagnosticsVotlageDivider
            // 
            this.checkBox_diagnosticsVotlageDivider.AutoSize = true;
            this.checkBox_diagnosticsVotlageDivider.Location = new System.Drawing.Point(643, 200);
            this.checkBox_diagnosticsVotlageDivider.Name = "checkBox_diagnosticsVotlageDivider";
            this.checkBox_diagnosticsVotlageDivider.Size = new System.Drawing.Size(145, 17);
            this.checkBox_diagnosticsVotlageDivider.TabIndex = 7;
            this.checkBox_diagnosticsVotlageDivider.Text = "External Voltage Divider?";
            this.checkBox_diagnosticsVotlageDivider.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(713, 226);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(0, 13);
            this.label55.TabIndex = 18;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(640, 92);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(0, 13);
            this.label56.TabIndex = 20;
            // 
            // scatterGraph_diagnostics
            // 
            this.scatterGraph_diagnostics.Location = new System.Drawing.Point(3, 3);
            this.scatterGraph_diagnostics.Name = "scatterGraph_diagnostics";
            this.scatterGraph_diagnostics.Size = new System.Drawing.Size(631, 414);
            this.scatterGraph_diagnostics.TabIndex = 13;
            // 
            // textBox_diagnosticsResults
            // 
            this.textBox_diagnosticsResults.Location = new System.Drawing.Point(6, 423);
            this.textBox_diagnosticsResults.MaxLength = 327670;
            this.textBox_diagnosticsResults.Multiline = true;
            this.textBox_diagnosticsResults.Name = "textBox_diagnosticsResults";
            this.textBox_diagnosticsResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_diagnosticsResults.Size = new System.Drawing.Size(628, 348);
            this.textBox_diagnosticsResults.TabIndex = 10;
            // 
            // textBox_voltageDivider
            // 
            this.textBox_voltageDivider.Location = new System.Drawing.Point(773, 223);
            this.textBox_voltageDivider.Name = "textBox_voltageDivider";
            this.textBox_voltageDivider.Size = new System.Drawing.Size(100, 20);
            this.textBox_voltageDivider.TabIndex = 8;
            // 
            // textBox_diagnosticsMult
            // 
            this.textBox_diagnosticsMult.Location = new System.Drawing.Point(827, 89);
            this.textBox_diagnosticsMult.Name = "textBox_diagnosticsMult";
            this.textBox_diagnosticsMult.Size = new System.Drawing.Size(46, 20);
            this.textBox_diagnosticsMult.TabIndex = 3;
            // 
            // checkBox_diagnosticsDigitalFilter
            // 
            this.checkBox_diagnosticsDigitalFilter.AutoSize = true;
            this.checkBox_diagnosticsDigitalFilter.Location = new System.Drawing.Point(643, 253);
            this.checkBox_diagnosticsDigitalFilter.Name = "checkBox_diagnosticsDigitalFilter";
            this.checkBox_diagnosticsDigitalFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBox_diagnosticsDigitalFilter.TabIndex = 9;
            this.checkBox_diagnosticsDigitalFilter.Text = "Digital Filter";
            this.checkBox_diagnosticsDigitalFilter.UseVisualStyleBackColor = true;
            // 
            // tabPage_diagnostics
            // 
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsDigitalFilter);
            this.tabPage_diagnostics.Controls.Add(this.textBox_diagnosticsMult);
            this.tabPage_diagnostics.Controls.Add(this.textBox_voltageDivider);
            this.tabPage_diagnostics.Controls.Add(this.textBox_diagnosticsResults);
            this.tabPage_diagnostics.Controls.Add(this.scatterGraph_diagnostics);
            this.tabPage_diagnostics.Controls.Add(this.label56);
            this.tabPage_diagnostics.Controls.Add(this.label55);
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsVotlageDivider);
            this.tabPage_diagnostics.Controls.Add(this.checkBox_diagnosticsBulk);
            this.tabPage_diagnostics.Controls.Add(this.label42);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_numPeriods);
            this.tabPage_diagnostics.Controls.Add(this.label41);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_diagnosticsVoltage);
            this.tabPage_diagnostics.Controls.Add(this.label40);
            this.tabPage_diagnostics.Controls.Add(this.label39);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_startFreq);
            this.tabPage_diagnostics.Controls.Add(this.numericUpDown_stopFreq);
            this.tabPage_diagnostics.Controls.Add(this.button_computeGain);
            this.tabPage_diagnostics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_diagnostics.Name = "tabPage_diagnostics";
            this.tabPage_diagnostics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_diagnostics.Size = new System.Drawing.Size(942, 780);
            this.tabPage_diagnostics.TabIndex = 6;
            this.tabPage_diagnostics.Text = "Diagnostics";
            this.tabPage_diagnostics.UseVisualStyleBackColor = true;
            // 
            // NeuroRighter
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(100, 800);
            this.ClientSize = new System.Drawing.Size(1211, 830);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NeuroRighter";
            this.Text = "NeuroRighter v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuroControl_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_recording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_record)).EndInit();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDurationSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timedRecordingDuration)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox_SALPA.ResumeLayout(false);
            this.groupBox_SALPA.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_asym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_ahead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_forcepeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_postpeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salpa_halfwidth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpikeLowCut)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_sidebar.ResumeLayout(false);
            this.tabPage_SpikeFilters.ResumeLayout(false);
            this.tabPage_OtherFilters.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EEGFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EEGLowCut)).EndInit();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MUAFilterOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MUAHighCut)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LFPFiltOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPHighCut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LFPLowCut)).EndInit();
            this.tabPage_MiscSettings.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelOut)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.tabPage_ProgRef.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefSpikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_digRefLFPs)).EndInit();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CommonMedianLocalReferencingChannelsPerGroup)).EndInit();
            this.groupBox_plexonProgRef.ResumeLayout(false);
            this.groupBox_plexonProgRef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefSpikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_analogRefLFPs)).EndInit();
            this.tabPage_impedance.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RCurr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impCommandVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impStartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impNumPeriods)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_impedance)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_impChannel)).EndInit();
            this.tabPage_stim.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimPulses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimInterphaseLength)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_exptNumRepeats)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopInterphaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopVoltage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopWidth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPrephaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openLoopPostphaseLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph_openLoopStimPulse)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_electrolesioningDuration)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_pulsePerTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_phaseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IISZapper_channel)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetVoltage)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfOpenLoopRepeats)).EndInit();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.tabPage_AuxInput.ResumeLayout(false);
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_AuxAnalogData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AnalogDispMaxVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AnalogDispWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slide_AuxShift)).EndInit();
            this.groupBox28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledArray_DigitalState.ItemTemplate)).EndInit();
            this.tabPage_waveforms.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumSnipsDisplayed)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diagnosticsVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph_diagnostics)).EndInit();
            this.tabPage_diagnostics.ResumeLayout(false);
            this.tabPage_diagnostics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_OutputFile;
        private System.Windows.Forms.ToolTip toolTip_outputFilename;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_spikesFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SpikeHighCut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpikeLowCut;
        private System.Windows.Forms.Label label8;
        private NationalInstruments.UI.WindowsForms.Switch switch_record;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox_video;
        private System.Windows.Forms.Timer timer_expt;
        private System.ComponentModel.BackgroundWorker bw_genExpt;
        private System.ComponentModel.BackgroundWorker bw_stim;
        private System.Windows.Forms.Button button_scaleUp;
        private System.Windows.Forms.Button button_scaleDown;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.ComponentModel.BackgroundWorker bw_openLoop;
        private System.Windows.Forms.Button button_scaleReset;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown SpikeFiltOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox_freeze;
        private NationalInstruments.UI.WaveformPlot spkWfmPlot1;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        private NationalInstruments.UI.WindowsForms.Led led_recording;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DisplaySettings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_timeElapsed;
        private System.Windows.Forms.Timer timer_timeElapsed;
        private System.Windows.Forms.TabControl tabControl_sidebar;
        private System.Windows.Forms.TabPage tabPage_SpikeFilters;
        private System.Windows.Forms.TabPage tabPage_MiscSettings;
        private System.Windows.Forms.ImageList imageList_zoomButtons;
        private System.Windows.Forms.NumericUpDown numericUpDown_timedRecordingDuration;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.CheckBox checkBox_enableTimedRecording;
        private System.Windows.Forms.GroupBox groupBox_SALPA;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_ahead;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_forcepeg;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_postpeg;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_halfwidth;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.NumericUpDown numericUpDown_timedRecordingDurationSeconds;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.CheckBox checkbox_repeatRecord;
        private System.Windows.Forms.CheckBox checkBox_RetrainOnRestart;
        private System.Windows.Forms.Button button_EnterNote;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button_TrainSpkDet;
        private System.Windows.Forms.Button button_OpenSpkDetSettings;
        private System.Windows.Forms.GroupBox groupBox26;
        private Mowog.PersistWindowComponent NRPersistWindowComponent;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button button_SetRecordingStreams;
        private System.Windows.Forms.Button button_BrowseOutputFile;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox checkBox_SALPA;
        private System.Windows.Forms.NumericUpDown numericUpDown_salpa_asym;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.NumericUpDown channelOut;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem showConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem documenationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeAPIReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_Train;
        private System.Windows.Forms.Label label_noise;
        private System.Windows.Forms.TabPage tabPage_OtherFilters;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.CheckBox checkBox_artiFilt;
        private System.Windows.Forms.NumericUpDown LFPFiltOrder;
        private System.Windows.Forms.NumericUpDown LFPHighCut;
        private System.Windows.Forms.NumericUpDown LFPLowCut;
        private System.Windows.Forms.CheckBox checkBox_LFPsFilter;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_MUAFilterOrder;
        private System.Windows.Forms.CheckBox checkBox_MUAFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_MUAHighCut;
        private System.Windows.Forms.ToolStripMenuItem codeRespositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedloopExampleCodesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown EEGFiltOrder;
        private System.Windows.Forms.NumericUpDown EEGHighCut;
        private System.Windows.Forms.NumericUpDown EEGLowCut;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_spikes;
        private System.Windows.Forms.TabPage tabPage_waveforms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_clearSpkWfms;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumSnipsDisplayed;
        private System.Windows.Forms.TabPage tabPage_AuxInput;
        private System.Windows.Forms.GroupBox groupBox28;
        private NationalInstruments.UI.WindowsForms.LedArray ledArray_DigitalState;
        private System.Windows.Forms.GroupBox groupBox33;
        private NationalInstruments.UI.WindowsForms.Slide slide_AuxShift;
        private System.Windows.Forms.CheckBox checkBox_FreezeAuxPlot;
        private NationalInstruments.UI.WindowsForms.Slide slide_AnalogDispWidth;
        private NationalInstruments.UI.WindowsForms.Slide slide_AnalogDispMaxVoltage;
        internal NationalInstruments.UI.WindowsForms.ScatterGraph scatterGraph_AuxAnalogData;
        private NationalInstruments.UI.ScatterPlot scatterPlot3;
        private NationalInstruments.UI.XAxis xAxis5;
        private NationalInstruments.UI.YAxis yAxis5;
        private System.Windows.Forms.TabPage tabPage_LFPs;
        private System.Windows.Forms.TabPage tabPage_MUA;
        private System.Windows.Forms.TabPage tabPage_EEG;
        private System.Windows.Forms.TabPage tabPage_stim;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.ComboBox comboBox_closedLoopProtocol;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.CheckBox checkBox_useManStimWaveformCL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_browseCLStimFiles;
        private System.Windows.Forms.Button button_stopClosedLoopStim;
        private System.Windows.Forms.TextBox textBox_ClosedLoopProtocolFile;
        private System.Windows.Forms.Button button_startClosedLoopStim;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfOpenLoopRepeats;
        private System.Windows.Forms.CheckBox checkBox_RepeatOpenLoopProtocol;
        private System.Windows.Forms.Button button_browseAuxFile;
        private System.Windows.Forms.TextBox textBox_AuxFile;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.CheckBox checkBox_useManStimWaveform;
        private System.Windows.Forms.Button button_BrowseOLDFile;
        private System.Windows.Forms.TextBox textBox_digitalProtocolFileLocation;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button button_BrowseOLStimFile;
        private System.Windows.Forms.Button button_stopStimFromFile;
        private System.Windows.Forms.TextBox textBox_protocolFileLocations;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Button button_startStimFromFile;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RadioButton radioButton_stimVoltageControlled;
        private System.Windows.Forms.RadioButton radioButton_stimCurrentControlled;
        private System.Windows.Forms.NumericUpDown offsetVoltage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button button_IISZapper_stop;
        private System.Windows.Forms.Button button_IISZapper_start;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_channel;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_phaseWidth;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_rate;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_voltage;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.NumericUpDown numericUpDown_IISZapper_pulsePerTrain;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Button button_electrolesioningSelectNone;
        private System.Windows.Forms.Button button_electrolesioningSelectAll;
        private System.Windows.Forms.ListBox listBox_electrolesioningChannels;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numericUpDown_electrolesioningDuration;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown numericUpDown_electrolesioningVoltage;
        private System.Windows.Forms.Button button_electrolesioningStart;
        private System.Windows.Forms.GroupBox groupBox12;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph_openLoopStimPulse;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button button_openLoopSelectNone;
        private System.Windows.Forms.Button button_openLoopSelectAll;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown openLoopPostphaseLength;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown openLoopPrephaseLength;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown openLoopWidth2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown openLoopVoltage2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown openLoopInterphaseLength;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListBox listBox_stimChannels;
        private System.Windows.Forms.Button openLoopStop;
        private System.Windows.Forms.Button openLoopStart;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown openLoopWidth1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown openLoopVoltage1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown openLoopRate;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button_ElectrodeScreeningSelectNone;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button button_ElectrodeScreeningSelectAll;
        private System.Windows.Forms.NumericUpDown numericUpDown_exptNumRepeats;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox_exptPulseWidths;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox_exptPPT;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox_exptVoltages;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button_stopExpt;
        private System.Windows.Forms.ListBox listBox_exptStimChannels;
        private System.Windows.Forms.ProgressBar progressBar_stimExpt;
        private System.Windows.Forms.Button button_stimExpt;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton radioButton_OnDemandBiphasic;
        private System.Windows.Forms.RadioButton radioButton_OnDemandUniphasic;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown stimInterphaseLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown stimChannel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown stimWidth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown stimRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown stimVoltage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown stimPulses;
        private System.Windows.Forms.Button button_stim;
        private System.Windows.Forms.TabPage tabPage_impedance;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.CheckBox checkBox_impedanceAllChannels;
        private System.Windows.Forms.NumericUpDown numericUpDown_impChannel;
        private NationalInstruments.UI.WindowsForms.ScatterGraph scatterGraph_impedance;
        private NationalInstruments.UI.ScatterPlot scatterPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox textBox_impedanceResults;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox checkBox_impUseMatchedFilter;
        private System.Windows.Forms.CheckBox checkBox_impBandpassFilter;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numericUpDown_impNumPeriods;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numericUpDown_impStartFreq;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown numericUpDown_impStopFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_impCommandVoltage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numericUpDown_RMeas;
        private System.Windows.Forms.NumericUpDown numericUpDown_RGain;
        private System.Windows.Forms.NumericUpDown numericUpDown_RCurr;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton radioButton_impVoltage;
        private System.Windows.Forms.RadioButton radioButton_impCurrent;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.Label label_impedanceProgress;
        private System.Windows.Forms.Button button_impedanceSaveAsMAT;
        private System.Windows.Forms.ProgressBar progressBar_impedance;
        private System.Windows.Forms.Button button_impedanceTest;
        private System.Windows.Forms.Button button_impedanceCancel;
        private System.Windows.Forms.Button button_impedanceCopyDataToClipboard;
        private System.Windows.Forms.TabPage tabPage_ProgRef;
        private System.Windows.Forms.GroupBox groupBox_plexonProgRef;
        private System.Windows.Forms.Button button_analogResetRefs;
        private System.Windows.Forms.CheckBox checkBox_analogRefLFPs;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numericUpDown_analogRefLFPs;
        private System.Windows.Forms.CheckBox checkBox_analogRefSpikes;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numericUpDown_analogRefSpikes;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.NumericUpDown numericUpDown_CommonMedianLocalReferencingChannelsPerGroup;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonAverage;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonMedian;
        private System.Windows.Forms.RadioButton radioButton_spikesReferencingCommonMedianLocal;
        private System.Windows.Forms.RadioButton radioButton_spikeReferencingNone;
        private System.Windows.Forms.CheckBox checkBox_digRefLFPs;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown numericUpDown_digRefLFPs;
        private System.Windows.Forms.CheckBox checkBox_digRefSpikes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numericUpDown_digRefSpikes;
        private System.Windows.Forms.TabPage tabPage_diagnostics;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsDigitalFilter;
        private System.Windows.Forms.TextBox textBox_diagnosticsMult;
        private System.Windows.Forms.TextBox textBox_voltageDivider;
        private System.Windows.Forms.TextBox textBox_diagnosticsResults;
        private NationalInstruments.UI.WindowsForms.ScatterGraph scatterGraph_diagnostics;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsVotlageDivider;
        private System.Windows.Forms.CheckBox checkBox_diagnosticsBulk;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numericUpDown_numPeriods;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown numericUpDown_diagnosticsVoltage;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numericUpDown_startFreq;
        private System.Windows.Forms.NumericUpDown numericUpDown_stopFreq;
        private System.Windows.Forms.Button button_computeGain;
        private NationalInstruments.UI.YAxis yAxis4;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.ScatterPlot scatterPlot1;
    }
}