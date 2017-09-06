#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Times
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int product;
        int numProb;
        int numRight;
        Random myRandom = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize variables
            numProb = 0;
            numRight = 0;
            // display the first problem
            btnNext.PerformClick();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Generate next multiplication problem
            int number1, number2;
            txtAnswer.Text = "";
            lblMessage.Text = "";
            numProb++;
            // Generate random numbers for factors
            number1 = myRandom.Next(10);
            number2 = myRandom.Next(10);
            lblNum1.Text = Convert.ToString(number1);
            lblNum2.Text = Convert.ToString(number2);
            // Find product
            product = number1 * number2;
            btnNext.Enabled = false;
            txtAnswer.Focus();
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ans;
            // Check for number only input and for return key
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int) e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if ((int) e.KeyChar == 13)
            {
                // Check answer and update score
                ans = Convert.ToInt32(txtAnswer.Text);
                if (ans == product)
                {
                    numRight++;
                    lblMessage.Text = "That's correct!";
                }
                else
                {
                    lblMessage.Text = "Answer is " + Convert.ToString(product);
                }
                lblScore.Text = String.Format("{0:f0}", 100 * ((double) numRight / numProb)) + "%";
                btnNext.Enabled = true;
                btnNext.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}