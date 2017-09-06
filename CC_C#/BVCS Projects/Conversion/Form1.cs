#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Conversion
{
    using System;
    using System.Globalization;
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] units = new string[7];
        double [,] conversions = new double[7, 7];
        bool loading = true;
        NumberFormatInfo provider = new CultureInfo("en-US", false).NumberFormat;

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            // Establish conversion factors - stored in two dimensional array
            // or table - the first number is the table row, the second number
            // the table column
            conversions[0, 0] = 1; //in to in
            conversions[0, 1] = 1.0 / 12; //in to ft
            conversions[0, 2] = 1.0 / 36; // in to yd
            conversions[0, 3] = (1.0 / 12) / 5280; // in to mi
            conversions[0, 4] = 2.54; // in to cm
            conversions[0, 5] = 2.54 / 100; // in to m
            conversions[0, 6] = 2.54 / 100000; // in to km
            for (i = 0; i < 7; i++)
            {
                conversions[1, i] = 12 * conversions[0, i];
                conversions[2, i] = 36 * conversions[0, i];
                conversions[3, i] = 5280 * (12 * conversions[0, i]);
                conversions[4, i] = conversions[0, i] / 2.54;
                conversions[5, i] = 100 * conversions[0, i] / 2.54;
                conversions[6, i] = 100000 * (conversions[0, i] / 2.54);
            }
            // Initialize variables
            units[0] = "inches (in)";
            units[1] = "feet (ft)";
            units[2] = "yards (yd)";
            units[3] = "miles (mi)";
            units[4] = "centimeters (cm)";
            units[5] = "meters (m)";
            units[6] = "kilometers (km)";
            for (i = 0; i < 7; i++)
            {
                dudFromUnit.Items.Add(units[i]);
                dudToUnit.Items.Add(units[i]);
            }
            dudFromUnit.SelectedIndex = 0;
            dudToUnit.SelectedIndex = 0;
            provider.NumberDecimalDigits = 0;
            // Put cursor in text box
            txtFromValue.Focus();
            loading = false;
        }

        private void txtFromValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Numbers and decimal point only
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || (int) e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFromValue_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (loading)
            {
                return;
            }
            double v;
            // Do unit conversion
            v = conversions[dudFromUnit.SelectedIndex, dudToUnit.SelectedIndex] * Convert.ToDouble(txtFromValue.Text);
            txtToValue.Text = v.ToString("N", provider);
            txtFromValue.Focus();
        }

        private void dudFromUnit_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void dudToUnit_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void rdoDec0_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 0;
            UpdateDisplay();
        }

        private void rdoDec1_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 1;
            UpdateDisplay();
        }

        private void rdoDec2_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 2;
            UpdateDisplay();
        }

        private void rdoDec3_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 3;
            UpdateDisplay();
        }

        private void rdoDec4_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 4;
            UpdateDisplay();
        }

        private void rdoDec5_CheckedChanged(object sender, EventArgs e)
        {
            provider.NumberDecimalDigits = 5;
            UpdateDisplay();
        }



    }
}