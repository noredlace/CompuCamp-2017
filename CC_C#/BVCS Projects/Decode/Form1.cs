#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Decode
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool gameOver;
        string computerCode;
        string[] computerNumbers = new string[4];
        Random myRandom = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Click New Game";
            btnNew.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string[] nArray = new string[10];
            int i, j;
            string t;
            // Start new game
            btnStop.Enabled = true;
            gameOver = false;
            lblMessage.Text = "";
            txtGuesses.Text = "";
            txtGuess.Text = "";
            btnNew.Enabled = false;
            // Choose code using modified version of card shuffling routine
            // Order all digits initially
            computerCode = "";
            for (i = 0; i < 10; i++)
            {
                nArray[i] = Convert.ToString(i);
            }
            // J is number of integers remaining
            for (j = 9; j >=6; j--)
            {
                i = myRandom.Next(j);
                computerNumbers[9 - j] = nArray[i];
                computerCode = computerCode + nArray[i];
                t = nArray[j];
                nArray[j] = nArray[i];
                nArray[i] = t;
            }
            lblMessage.Text = "I have a 4 digit code.\r\nTry to guess it.";
            grpGuess.Visible = true;
            txtGuess.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop current game
            grpGuess.Visible = false;
            btnNew.Enabled = true;
            btnStop.Enabled = false;
            if (!gameOver)
            {
                lblMessage.Text = "Game Stopped\r\nMy code was - " + computerCode;
            }
            btnNew.Focus();
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers only
            if ((int) e.KeyChar == 13)
            {
                btnCheck.PerformClick();
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int) e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string w;
            string[] wNumbers = new string[4];
            int i, j, k1, k2;
            bool distinct;
            // Check your guess
            w = txtGuess.Text;
            // Check length validity
            if (w.Length != 4)
            {
                lblMessage.Text = "Guess must have 4 numbers ...\r\nTry again!";
                txtGuess.Focus();
                return;
            }
            else
            {
                // Get numbers and make sure they are distinct
                distinct = true;
                for (i = 0; i < 4; i++)
                {
                    wNumbers[i] = w.Substring(i, 1);
                    if (i != 0)
                    {
                        for (j = i - 1; j >= 0 ; j--)
                        {
                            if (wNumbers[i] == wNumbers[j])
                            {
                                distinct = false;
                            }
                        }
                    }
                }
                if (!distinct)
                {
                    lblMessage.Text = "Numbers must all be different ...\r\nTry again!";
                    txtGuess.Focus();
                    return;
                }
                if (w == computerCode)
                {
                    lblMessage.Text = "Congratulations!\r\nThat's my code - " + computerCode;
                    gameOver = true;
                    btnStop.PerformClick();
                    return;
                }
                else
                {
                    // Compute score
                    k1 = 0;
                    k2 = 0;
                    for (i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 4; j++)
                        {
                            if (wNumbers[j] == computerNumbers[i])
                                k1++;
                        }
                        if (wNumbers[i] == computerNumbers[i])
                            k2++;
                    }
                    lblMessage.Text = "Your guess - " + w + "\r\n" + Convert.ToString(k1) + " digit(s) correct\r\n" + Convert.ToString(k2) + " digit(s) in proper place";
                    txtGuesses.Text = w + "   " + Convert.ToString(k1) + "/" + Convert.ToString(k2) + "\r\n" + txtGuesses.Text;
                    txtGuess.Text = "";
                    txtGuess.Focus();
                }
            }
        }
    }
}