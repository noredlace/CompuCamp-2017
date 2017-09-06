#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Loan
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double loan, interest, months, payment, multiplier;
            // Read text boxes
            loan = Convert.ToDouble(txtLoan.Text);
            interest = Convert.ToDouble(txtInterest.Text);
            months = Convert.ToDouble(txtMonths.Text);
            // Compute interest multiplier
            multiplier = Math.Pow((1 + interest / 1200), months);
            // Compute payment
            payment = loan * interest * multiplier / (1200 * (multiplier - 1));
            txtPayment.Text = "$" + Convert.ToString(String.Format("{0:f2}", payment));
        }
    }
}