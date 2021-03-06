﻿using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using Clifton.Tools.Data;

namespace CANFICore
{
    // Objects to keep the calibration entries in an array
    // indexing is done by frequency and tuner gain
    // two-dimensional linear interpolation is done if frequency and/or tuner gain are not matching exactly and
    // the requested calibration value is in between at least two existing calibration entries

    public class CalEntries
    {
        CalFrequencies cf;

        private int _averaging = 1;

        private decimal _minfrequency = 0;
        private decimal _maxfrequency = 0;

        private int _maxgain = 0;
        private int _mingain = 0;

        public CalEntries(int averaging)
        {
            if (averaging > 0)
                _averaging = averaging;
            cf = new CalFrequencies();
        }

        #region Properties

        public int Averaging
        {
            get
            {
                return _averaging;
            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (KeyValuePair<decimal, CalGains> gains in cf)
                {
                    count += gains.Value.Count;
                }
                return count;
            }
        }

        public decimal MinFrequency
        {
            get
            {
                return _minfrequency;
            }
        }

        public decimal MaxFrequency
        {
            get
            {
                return _maxfrequency;
            }
        }

        public int MinGain
        {
            get
            {
                return _mingain;
            }
        }

        public int MaxGain
        {
            get
            {
                return _maxgain;
            }
        }

        #endregion

        #region Indexers

        public CalGains this[decimal f]
        {
            get
            {
                if (cf.Count == 0)
                    return null;
                CalGains gains = null;
                cf.TryGetValue(f, out gains);
                return gains;
            }
        }

        public CalEntry this[decimal f, int g]
        {
            get
            {
                // try to get a CalEntry back for given f and g
                // return null on empty list
                if (cf.Count == 0)
                    return null;
                // return the value by a separate method
                return this.GetValue(f, g);
            }
            set
            {
                // do nothing if value is invalid
                if (value.Invalid)
                    return;
                // set the value by a separate method
                this.SetValue(f,g,value);
            }
        }

        #endregion

        private CalEntry GetValue(decimal f, int g)
        {
            // try to get a CalEntry for given f and g
            //
            // TO BE DONE: 
            //
            // bilinear interpolation of values!
            //
            // until now a value is found when f and g are matching exactly
            CalGains gains = null;
            CalEntry e = null;
            if (!cf.TryGetValue(f, out gains))
                return null;
            if (!gains.TryGetValue(g, out e))
                return null;
            return e;
        }

        private void SetValue(decimal f, int g, CalEntry value)
        {
            // try to set a CalEntry for given f and g
            //
            // TO BE DONE: 
            //
            // handle different values for ENR!
            // until now it is assumed that all entries of given f and g are made with the same ENR value
            //
            CalGains gains = null;
            CalEntry e = null;
            // try to find a CalGains entry for a given f
            if (cf.TryGetValue(f, out gains))
            {
                // CalGains entry found
                // try to find a CalEntry for given g
                if (gains.TryGetValue(g, out e))
                {
                    // CalEntry found
                    // add values to existing
                    e.P_OFF.AddSample(value.P_OFF.Average);
                    e.P_ON.AddSample(value.P_ON.Average);
                    // try to calculate rest of values
                    try
                    {
                        e.Y = e.P_ON.Average / e.P_OFF.Average;
                        e.F = SupportFunctions.ToLinear(value.ENR) / (e.Y - 1);
                        e.NF = SupportFunctions.TodB(e.F);
                    }
                    catch
                    {
                        e.Y = 1;
                        e.F = 1;
                        e.NF = 0;
                    }
                }
                else
                {
                    // CalEntry not found --> generate and add new one
                    e = new CalEntry(Averaging);
                    e.Invalid = value.Invalid;
                    e.Frequency = value.Frequency;
                    e.TunerGain = value.TunerGain;
                    e.P_OFF.AddSample(value.P_OFF.Average);
                    e.P_ON.AddSample(value.P_ON.Average);
                    e.ENR = value.ENR;
                    // try to calculate rest of values
                    try
                    {
                        e.Y = e.P_ON.Average / e.P_OFF.Average;
                        e.F = SupportFunctions.ToLinear(value.ENR) / (e.Y - 1);
                        e.NF = SupportFunctions.TodB(e.F);
                    }
                    catch
                    {
                        e.Y = 1;
                        e.F = 1;
                        e.NF = 0;
                    }
                    gains.Add(g, e);
                    // maintain properties
                    if (e.Frequency < _minfrequency)
                        _minfrequency = e.Frequency;
                    if (e.Frequency > _maxfrequency)
                        _maxfrequency = e.Frequency;
                    if (e.TunerGain < _mingain)
                        _mingain = e.TunerGain;
                    if (e.TunerGain > _maxgain)
                        _maxgain = e.TunerGain;
                }
            }
            else
            {
                // CalGains entry not found --> generate new one from scratch
                gains = new CalGains();
                // add CallEntry first
                // CalEntry not found --> add new one
                e = new CalEntry(Averaging);
                e.Invalid = value.Invalid;
                e.Frequency = value.Frequency;
                e.TunerGain = value.TunerGain;
                e.P_OFF.AddSample(value.P_OFF.Average);
                e.P_ON.AddSample(value.P_ON.Average);
                e.ENR = value.ENR;
                // try to calculate rest of values
                try
                {
                    e.Y = e.P_ON.Average / e.P_OFF.Average;
                    e.F = SupportFunctions.ToLinear(e.ENR) / (e.Y - 1);
                    e.NF = SupportFunctions.TodB(e.F);
                }
                catch
                {
                    e.Y = 1;
                    e.F = 1;
                    e.NF = 0;
                }
                gains.Add(g, e);
                // maintain properties
                if (e.Frequency < _minfrequency)
                    _minfrequency = e.Frequency;
                if (e.Frequency > _maxfrequency)
                    _maxfrequency = e.Frequency;
                if (e.TunerGain < _mingain)
                    _mingain = e.TunerGain;
                if (e.TunerGain > _maxgain)
                    _maxgain = e.TunerGain;
                // add CalGains to list
                cf.Add(f, gains);
            }
        }

        public void Clear()
        {
            // clear all entries
            foreach (KeyValuePair<decimal, CalGains> gains in cf)
            {
                gains.Value.Clear();
            }
            cf.Clear();

            // reset properties
            _minfrequency = 0;
            _maxfrequency = 0;
            _mingain = 0;
            _maxgain = 0;
        }

        public void ExportToCSV(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("Invalid;Frequency;TunerGain;P_ON;P_OFF;Y;F;NF;ENR");
                foreach (KeyValuePair<decimal, CalGains> gains in cf)
                {
                    foreach (KeyValuePair<int, CalEntry> e in gains.Value)
                    {
                        sw.WriteLine(
                            e.Value.Invalid.ToString() + ";" +
                            e.Value.Frequency.ToString("F3") + ";" +
                            (e.Value.TunerGain/10).ToString() + ";" +
                            e.Value.P_ON.Average.ToString() + ";" +
                            e.Value.P_OFF.Average.ToString() + ";" +
                            e.Value.Y.ToString() + ";" +
                            e.Value.F.ToString() + ";" +
                            e.Value.NF.ToString() + ";" +
                            e.Value.ENR.ToString());
                    }
                }
            }
        }
    }

    
    public class CalFrequencies : SortedList<decimal,CalGains>
    {
    }

    public class CalGains : SortedList<int, CalEntry>
    {
    }

    // class for calibration entry
    public class CalEntry
    {
        // state
        public bool Invalid;
        // RTL tuner frequency
        public decimal Frequency;
        // RTL tuner gain
        public int TunerGain;
        // moving average for P_ON values
        public SimpleMovingAverage P_ON;
        // moving average for P_OFF values
        public SimpleMovingAverage P_OFF;
        // Y factor
        public double Y;
        // noise figure (linear), calculated from average P_ON and P_OFF values
        public double F;
        // noise figure (dB), calculated from average P_ON and P_OFF values
        public double NF;
        // ENR value used for calibration
        public double ENR;

        public CalEntry(int averaging)
        {
            // initialization of calibration entry, averaging is the depth of moving average
            Invalid = true;
            Frequency = 0;
            TunerGain = 0;
            P_ON = new SimpleMovingAverage(averaging);
            P_OFF = new SimpleMovingAverage(averaging);
            Y = 1;
            F = 1;
            NF = 0;
            ENR = 0;
        }
    }


}
