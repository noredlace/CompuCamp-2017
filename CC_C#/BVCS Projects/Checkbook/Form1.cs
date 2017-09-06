#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Checkbook
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double adjStmtBalance; //  adjusted statement balance
        double adjChkBalance; // adjusted checkbook balance

        private void btnStmtBalance_Click(object sender, EventArgs e)
        {
            // Read entered statement balance
            adjStmtBalance = Convert.ToDouble(txtStmtBalance.Text);
            // Disable balance, enable deposit and check
            btnStmtBalance.Enabled = false;
            btnStmtDeposit.Enabled = true;
            btnStmtCheck.Enabled = true;
            txtStmtBalance.ReadOnly = true;
            txtStmtDeposit.ReadOnly = false;
            txtStmtCheck.ReadOnly = false;
            btnStmtDeposit.Focus();
        }

        private void btnStmtDeposit_Click(object sender, EventArgs e)
        {
            // Account for uncredited deposit
            adjStmtBalance = adjStmtBalance + Convert.ToDouble(txtStmtDeposit.Text);
            txtAdjStmtBalance.Text = "$" + Convert.ToString(String.Format("{0:f2}", adjStmtBalance));
        }

        private void btnStmtCheck_Click(object sender, EventArgs e)
        {
            // Account for outstanding check
            adjStmtBalance = adjStmtBalance - Convert.ToDouble(txtStmtCheck.Text);
            txtAdjStmtBalance.Text = "$" + Convert.ToString(String.Format("{0:f2}", adjStmtBalance));
        }

        private void btnStmtReset_Click(object sender, EventArgs e)
        {
            // Reset statement values to defaults
            adjStmtBalance = 0;
            txtStmtBalance.Text = "0";
            txtStmtDeposit.Text = "0";
            txtStmtCheck.Text = "0";
            txtAdjStmtBalance.Text = "0";
            btnStmtBalance.Enabled = true;
            btnStmtDeposit.Enabled = false;
            btnStmtCheck.Enabled = false;
            txtStmtBalance.ReadOnly = false;
            txtStmtDeposit.ReadOnly = true;
            txtStmtCheck.ReadOnly = true;
            btnStmtBalance.Focus();
        }

        private void btnChkBalance_Click(object sender, EventArgs e)
        {
            // Read entered checkbook balance
            adjChkBalance = Convert.ToDouble(txtChkBalance.Text);
            // Disable balance, enabled deposit and charge
            btnChkBalance.Enabled = false;
            btnChkDeposit.Enabled = true;
            btnChkCharge.Enabled = true;
            txtChkBalance.ReadOnly = true;
            txtChkDeposit.ReadOnly = false;
            txtChkCharge.ReadOnly = false;
            btnChkDeposit.Focus();
        }

        private void btnChkDeposit_Click(object sender, EventArgs e)
        {
            // Account for unrecorded deposit
            adjChkBalance = adjChkBalance + Convert.ToDouble(txtChkDeposit.Text);
            txtAdjChkBalance.Text = "$" + Convert.ToString(String.Format("{0:f2}", adjChkBalance));
        }

        private void btnChkCharge_Click(object sender, EventArgs e)
        {
            // Account for service charge
            adjChkBalance = adjChkBalance - Convert.ToDouble(txtChkCharge.Text);
            txtAdjChkBalance.Text = "$" + Convert.ToString(String.Format("{0:f2}", adjChkBalance));
        }

        private void btnChkReset_Click(object sender, EventArgs e)
        {
            // Reset all checkbook values to defaults
            adjChkBalance = 0;
            txtChkBalance.Text = "0";
            txtChkDeposit.Text = "0";
            txtChkCharge.Text = "0";
            txtAdjChkBalance.Text = "0";
            btnChkBalance.Enabled = true;
            btnChkDeposit.Enabled = false;
            btnChkCharge.Enabled = false;
            txtChkBalance.ReadOnly = false;
            txtChkDeposit.ReadOnly = true;
            txtChkCharge.ReadOnly = true;
            btnChkBalance.Focus();
        }


    }
}