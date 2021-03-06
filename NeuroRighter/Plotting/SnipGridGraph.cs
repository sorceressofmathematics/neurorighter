﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace NeuroRighter
{
    /// <summary>
    /// <author> Jon Newman</author>
    /// This Class is an extension of the gridgraph class for plotting a grid of data.
    /// </summary>
    sealed internal class SnipGridGraph : GraphicsDeviceControl
    {
        private float minX = 0F;
        private float maxX = 1F;
        private float minY = 0F;
        private float maxY = 1F;
        private float dX = 1F;
        private float dY = 1F;
        private float xScale;
        private float yScale;
        private float alpha = 0.5F;

        private int numRows;
        private int numCols;
        private int numSamplesPerPlot;
        private bool _isSpikeWaveformPlot;
        internal bool isSpikeWaveformPlot
        {
            get { return _isSpikeWaveformPlot; }
        }

        private static readonly object lockObject = new object();

        private Color gridColor = Color.White;

        BasicEffect effect;
        List<VertexPositionColor[]> lines; //Lines to be plotted
        List<VertexPositionColor[]> gridLines; //Grid lines
        short[] idx; //Index to points in 'lines'
        private static readonly short[] gridIdx = { 0, 1 }; //Index to points in gridLines

        //Constants for text rendering
        private ContentManager content;
        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private Dictionary<int, Vector2> channelNumberLocations;
        private Dictionary<int, String> channelNumberText;
        private String voltageTimeLabel;
        private double displayGain = 1;
        private double voltageRange; //in volts
        private double timeRange; //in seconds
        private Vector2 voltageTimeLabelCoords;
   

        private int waveformsPerPlot;

        internal void setup(int numRows, int numColumns, int waveformsPerPlot,
            int numSamplesPerPlot, bool isSpikeWaveformPlot, double timeRange, double voltageRange)
        {
            lock (lockObject)
            {
                this.numRows = numRows; this.numCols = numColumns; this._isSpikeWaveformPlot = isSpikeWaveformPlot;
                this.numSamplesPerPlot = numSamplesPerPlot;
                this.waveformsPerPlot = waveformsPerPlot;

                lines = new List<VertexPositionColor[]>(numCols * numRows * waveformsPerPlot);
                for (int i = 0; i < numCols * numRows * waveformsPerPlot; ++i)
                    lines.Add(new VertexPositionColor[numSamplesPerPlot]);
                idx = new short[numSamplesPerPlot];


                gridLines = new List<VertexPositionColor[]>(numRows + numCols - 2);

                for (int i = 0; i < numRows + numCols - 2; ++i) gridLines.Add(new VertexPositionColor[2]);
                for (short i = 0; i < idx.Length; ++i) 
                    idx[i] = i;

                this.timeRange = timeRange;
                this.voltageRange = voltageRange;

            }

        }

        internal void clear()
        {
            lock (lockObject)
            {
                lines.Clear();
                for (int i = 0; i < numCols * numRows * waveformsPerPlot; ++i)
                    lines.Add(new VertexPositionColor[numSamplesPerPlot]);
            }
        }

        protected override void Initialize()
        {
            effect = new BasicEffect(GraphicsDevice);
            effect.VertexColorEnabled = true;
            effect.View = Matrix.CreateLookAt(new Vector3(0, 0, 1), Vector3.Zero, Vector3.Up);
            effect.Projection = Matrix.CreateOrthographicOffCenter(0, this.Width, this.Height, 0, 1, 1000);

            // Graphics device options
            //GraphicsDevice.BlendState = BlendState.AlphaBlend;
            GraphicsDevice.BlendState = BlendState.NonPremultiplied;

            content = new ContentManager(Services, "Content");
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = content.Load<SpriteFont>("NRArial");

            this.Resize += new EventHandler(resize);
            this.SizeChanged += new EventHandler(resize);
            this.VisibleChanged += new EventHandler(resize);
        }

        internal void resize(object sender, System.EventArgs e)
        {
            if (!(this.Disposing) && effect != null)
            {
                effect.Projection = Matrix.CreateOrthographicOffCenter(0F, this.Width, this.Height, 0F, 1F, 1000F);
                xScale = (float)this.Width / dX;
                yScale = -(float)this.Height / dY;

                plotGridLines();
                updateChannelNumbers();
                updateVoltageTime();
            }
        }

        internal void setMinMax(float minX, float maxX, float minY, float maxY)
        {
            lock (lockObject)
            {
                this.minX = minX;
                this.minY = minY;
                this.maxX = maxX;
                this.maxY = maxY;
                dX = maxX - minX;
                dY = maxY - minY;
                xScale = (float)this.Width / dX;
                yScale = -(float)this.Height / dY;
            }
        }

        // General case for no sorting
        internal void plotY(float[] data, float firstX, float incrementX, List<Color> colorWave, int chan,
            int plotNumber)
        {
            lock (lockObject)
            {
                try
                {
                    for (int i = 0; i < lines[plotNumber].Length; ++i)
                        lines[plotNumber][i] = new VertexPositionColor(new Vector3(xScale * (firstX + incrementX * i - minX),
                            yScale * ((float)data[i] - maxY), 0), colorWave[chan] * alpha);
                }
                catch
                {
                    return;
                }
            }
        }

        // Case where you have sorted and color is based on unit number
        internal void plotY(float[] data, float firstX, float incrementX, Color colorWave, int chan,
            int plotNumber)
        {
            lock (lockObject)
            {
                try
                {
                    for (int i = 0; i < lines[plotNumber].Length; ++i)
                        lines[plotNumber][i] = new VertexPositionColor(new Vector3(xScale * (firstX + incrementX * i - minX),
                            yScale * ((float)data[i] - maxY), 0), colorWave * alpha);
                }
                catch
                {
                    return;
                }

            }

        }

        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.Black);

            //Draw channel numbers
            plotChannelNumbers();
            plotVoltageTime();

            effect.CurrentTechnique.Passes[0].Apply();

            for (int i = 0; i < gridLines.Count; ++i)
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    gridLines[i], 0, 2, gridIdx, 0, 1);
            for (int i = 0; i < lines.Count; ++i)
                GraphicsDevice.DrawUserIndexedPrimitives<VertexPositionColor>(PrimitiveType.LineStrip,
                    lines[i], 0, idx.Length, idx, 0, idx.Length - 1);
        }

        private void plotGridLines()
        {
            float boxHeight = (float)this.Height / numRows;
            float boxWidth = (float)this.Width / numCols;

            //Draw horz. lines
            for (int i = 0; i < numRows - 1; ++i)
            {
                gridLines[i][0] = new VertexPositionColor(new Vector3(0F, boxHeight * (i + 1), 0F),
                    gridColor);
                gridLines[i][1] = new VertexPositionColor(new Vector3(this.Width, boxHeight * (i + 1), 0F),
                    gridColor);
            }
            //Draw vert. lines
            for (int i = 0; i < numCols - 1; ++i)
            {
                gridLines[i + numRows - 1][0] = new VertexPositionColor(new Vector3(boxWidth * (i + 1),
                    0F, 0F), gridColor);
                gridLines[i + numCols - 1][1] = new VertexPositionColor(new Vector3(boxWidth * (i + 1),
                    this.Height, 0F), gridColor);
            }
        }

        private void plotChannelNumbers()
        {
            spriteBatch.Begin();
            for (int i = 1; i <= channelNumberText.Count; ++i)
                spriteBatch.DrawString(font, channelNumberText[i], channelNumberLocations[i], Color.White);
            spriteBatch.End();
        }

        private void updateChannelNumbers()
        {
            float boxHeight = (float)this.Height / numRows;
            float boxWidth = (float)this.Width / numCols;

            const int MARGIN = 5; //Pixels from vert/horz grid for each label
            //labels will be in upper left of each box

            if (channelNumberLocations == null)
                channelNumberLocations = new Dictionary<int, Vector2>(numCols * numRows);
            else channelNumberLocations.Clear();

            if (channelNumberText == null)
                channelNumberText = new Dictionary<int, string>(numCols * numRows);
            else channelNumberText.Clear();

            int i = 1;
            for (int r = 0; r < numRows; ++r)
            {
                for (int c = 0; c < numCols; ++c)
                {
                    channelNumberLocations.Add(i, new Vector2(boxWidth * c + MARGIN, boxHeight * r + MARGIN));
                    channelNumberText.Add(i, i.ToString());
                    ++i;
                }
            }
        }

        private void plotVoltageTime()
        {
            spriteBatch.Begin();
            lock (voltageTimeLabelLock)
            {
                spriteBatch.DrawString(font, voltageTimeLabel, voltageTimeLabelCoords, Color.White);
            }
            spriteBatch.End();
        }

        private object voltageTimeLabelLock = new object();

        private void updateVoltageTime()
        {
            if (font != null) //Prevents this from being called if object isn't initalized
            {
                const int VERTICAL_MARGIN = 5;
                const int HORIZONTAL_MARGIN = 5;

                double displayVoltage = voltageRange / displayGain;

                lock (voltageTimeLabelLock)
                {
                    if (displayVoltage >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage) + " V, ";
                    else if (displayVoltage * 1000 >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage * 1000) + " mV, ";
                    else if (displayVoltage * 1E6 >= 1)
                        voltageTimeLabel = @"+-" + Math.Ceiling(displayVoltage * 1E6) + " uV, ";

                    voltageTimeLabel += Math.Round(timeRange*10000)/10 + " ms";

                    Vector2 stringExtent = font.MeasureString(voltageTimeLabel);
                    voltageTimeLabelCoords = new Vector2(this.Width - stringExtent.X - HORIZONTAL_MARGIN, this.Height - stringExtent.Y - VERTICAL_MARGIN);
                }
            }
        }

        internal void setDisplayGain(double gain)
        {
            displayGain = gain;
            updateVoltageTime();
        }

        protected override void Dispose(bool disposing)
        {
            if (content != null)
                content.Unload();
            base.Dispose(disposing);
        }

        #region Public Accessors
        public int WaveformsToPlot
        {
            set
            {
                waveformsPerPlot = value;
            }
            get
            {
                return waveformsPerPlot;
            }
        }
        #endregion
    }
}

