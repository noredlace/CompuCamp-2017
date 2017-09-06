#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Stopwatch
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime startTime; // time when stopwatch started
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            // Starting timer?
            if (btnStartStop.Text == "Start")
            {
                // Reset Text on Start/Stop button
                btnStartStop.Text = "Stop";
                // Start timer and get starting time
                timDisplay.Enabled = true;
                startTime = DateTime.Now;
            }
            else
            {
                // Stop timer
                timDisplay.Enabled = false;
                // Disable Start/Stop button, enable Reset button
                btnStartStop.Enabled = false;
                btnReset.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset display to zero
            txtTime.Text = "00:00:00";
            // Reset button Text and enable Start, disable Reset
            btnStartStop.Text = "Start";
            btnStartStop.Enabled = true;
            btnReset.Enabled = false;
        }

        private void timDisplay_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime;
            // Determine elapsed time since Start was clicked
            elapsedTime = DateTime.Now - startTime;
            // Display time in label box
            txtTime.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds));
        }
    }
}