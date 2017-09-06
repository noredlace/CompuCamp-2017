#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Portfolio
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numberStocks;
        int currentStock;
        DateTime[] stockDate = new DateTime[25];
        string[] stockName = new string[25];
        double[] stockPrice = new double[25];
        int[] stockShares = new int[25];

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load stock Information
            numberStocks = 6;
            stockDate[0] = new DateTime(2002, 2, 10); stockName[0] = "Only Go Up";
            stockPrice[0] = 10; stockShares[0] = 50;
            stockDate[1] = new DateTime(2001, 2, 1); stockName[1] = "Big Deal";
            stockPrice[1] = 10; stockShares[1] = 100;
            stockDate[2] = new DateTime(2001, 3, 1); stockName[2] = "Web Winner";
            stockPrice[2] = 20; stockShares[2] = 300;
            stockDate[3] = new DateTime(2003, 4, 10); stockName[3] = "Little Blue";
            stockPrice[3] = 15; stockShares[3] = 200;
            stockDate[4] = new DateTime(1999, 5, 21); stockName[4] = "My Company";
            stockPrice[4] = 40; stockShares[4] = 400;
            stockDate[5] = new DateTime(2000, 11, 1); stockName[5] = "Your Company";
            stockPrice[5] = 30; stockShares[5] = 200;
            txtTodayDate.Text = DateTime.Today.ToShortDateString();
            currentStock = 0;
            this.Show();
            ShowStock();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // display previous stock
            if (currentStock != 0)
            {
                currentStock--;
                ShowStock();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // display next stock
            if (currentStock != numberStocks - 1)
            {
                currentStock++;
                ShowStock();
            }
        }

        private void ShowStock()
        {
            // Change displayed stock
            grpstock.Text = stockName[currentStock];
            txtDate.Text = stockDate[currentStock].ToShortDateString();
            txtPrice.Text = Convert.ToString(stockPrice[currentStock]);
            txtShares.Text = Convert.ToString(stockShares[currentStock]);
            txtPaid.Text = String.Format("{0:f2}", stockPrice[currentStock] * stockShares[currentStock]);
            // Allow computation of return
            txtToday.Text = "";
            txtValue.Text = "0.00";
            txtReturn.Text = "0.00%";
            txtToday.Focus();
        }
  

        private void txtToday_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers,decimal backspace
            if ((int) e.KeyChar == 13)
            {
                // If Return key pressed, then click the compute button
                btnReturn.PerformClick();
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || (int) e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // compute todays value and percent return
            double p, v, r;
            p = Convert.ToDouble(txtToday.Text);
            v = p * stockShares[currentStock];
            txtValue.Text = String.Format("{0:f2}", v);
            // Daily increase
            TimeSpan diff = DateTime.Today - stockDate[currentStock];
            r = (v / Convert.ToDouble(txtPaid.Text) - 1) / diff.Days;
            // Yearly return
            r = 100 * (365 * r);
            txtReturn.Text = String.Format("{0:f2}", r) + "%";
        }
    }
}