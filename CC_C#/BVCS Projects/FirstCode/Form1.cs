﻿#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace FirstCode
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            btnBeep.BackColor = Color.Blue;
        }

    }
}