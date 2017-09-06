#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Frown
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool gameOver;
        int whoseTurn, dice1, dice2;
        int youScore, computerScore;
        int youTotal, computerTotal;
        const int win = 100;
        Random myRandom = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize dice to frowns
            lblMessage.Text = "Click New Game To Start";
            picDice1.Image = picDots1.Image;
            picDice2.Image = picDots1.Image;
            btnNew.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Start new game
            gameOver = false;
            lblMessage.Text = "";
            btnNew.Enabled = false;
            btnStop.Text = "Stop Game";
            youScore = 0;
            lblYouScore.Text = "";
            computerScore = 0;
            lblComputerScore.Text = "";
            youTotal = 0;
            lblYouTotal.Text = "0";
            computerTotal = 0;
            lblComputerTotal.Text = "0";
            if (myRandom.Next(2) == 0)
            {
                // Computer goes first
                whoseTurn = 0;
                lblComputerScore.Text = "0";
                lblMessage.Text = "I'll roll first.";
                // must call instead of performclick since button is not
                // enabled
                btnRoll_Click(null, null);
            }
            else
            {
                // You go first
                whoseTurn = 1;
                lblYouScore.Text = "0";
                lblMessage.Text = "You roll first.";
                btnRoll.Enabled = true;
                btnRoll.Focus();
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Dice rolling
            // Roll Dice 1 and set display
            dice1 = myRandom.Next(6) + 1;
            switch (dice1)
            {
                case 1:
                    picDice1.Image = picDots1.Image;
                    break;
                case 2:
                    picDice1.Image = picDots2.Image;
                    break;
                case 3:
                    picDice1.Image = picDots3.Image;
                    break;
                case 4:
                    picDice1.Image = picDots4.Image;
                    break;
                case 5:
                    picDice1.Image = picDots5.Image;
                    break;
                case 6:
                    picDice1.Image = picDots6.Image;
                    break;
            }
            // Roll Dice 2 and set display
            dice2 = myRandom.Next(6) + 1;
            switch (dice2)
            {
                case 1:
                    picDice2.Image = picDots1.Image;
                    break;
                case 2:
                    picDice2.Image = picDots2.Image;
                    break;
                case 3:
                    picDice2.Image = picDots3.Image;
                    break;
                case 4:
                    picDice2.Image = picDots4.Image;
                    break;
                case 5:
                    picDice2.Image = picDots5.Image;
                    break;
                case 6:
                    picDice2.Image = picDots6.Image;
                    break;
            }
            picDice1.Refresh();
            picDice2.Refresh();
            if (whoseTurn == 0)
            {
                // Computer rolled
                if (dice1 > 1 && dice2 > 1)
                {
                    // No frowns
                    computerScore = computerScore + dice1 + dice2;
                    lblComputerScore.Text = Convert.ToString(computerScore);
                    timComputer.Enabled = true;
                    lblMessage.Text = lblMessage.Text + " Let me think ...";
                    return;
                }
                else if (dice1 == 1 && dice2 == 1)
                {
                    // Two frowns - lose everything - must pass
                    lblMessage.Text = lblMessage.Text + "\r\nI lost all my points!\r\nYour turn.";
                    computerTotal = 0;
                    lblComputerTotal.Text = "0";
                }
                else
                {
                    // One frown - must pass
                    lblMessage.Text = lblMessage.Text + "\r\nI lost my turn.\r\nYour turn.";
                }
                computerScore = 0;
                lblComputerScore.Text = "";
                whoseTurn = 1;
                btnRoll.Enabled = true;
                btnRoll.Focus();
            }
            else
            {
                // You rolled
                lblMessage.Text = "Still your turn.";
                btnPass.Enabled = true;
                if (dice1 > 1 && dice2 > 1)
                {
                    // No frowns
                    youScore = youScore + dice1 + dice2;
                    lblYouScore.Text = Convert.ToString(youScore);
                }
                else if (dice1 == 1 && dice2 == 1)
                {
                    // Two frowns - lose everything - must pass
                    youScore = 0;
                    youTotal = 0;
                    lblMessage.Text = "You lost everything.\r\nYou must pass to me.";
                    btnRoll.Enabled = false;
                    btnPass.Focus();
                }
                else
                {
                    // One frown - must pass
                    youScore = 0;
                    lblMessage.Text = "You lost your turn.\r\nYou must pass to me.";
                    btnRoll.Enabled = false;
                    btnPass.Focus();
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            // You passed dice to computer
            btnRoll.Enabled = false;
            btnPass.Enabled = false;
            whoseTurn = 0;
            youTotal = youTotal + youScore;
            youScore = 0;
            lblYouScore.Text = "";
            lblYouTotal.Text = Convert.ToString(youTotal);
            if (youTotal >= win)
            {
                gameOver = true;
                lblMessage.Text = "You win!!";
                btnStop.PerformClick();
            }
            else
            {
                lblMessage.Text = "I'll roll now.";
                // call btnroll routine, we can't use performclick method
                // since button is not enabled at this point
                btnRoll_Click(null, null);
            }
        }


        private void timComputer_Tick(object sender, EventArgs e)
        {
            int v;
            int odds;
            // Computer turn - decide wheter to roll again or pass
            timComputer.Enabled = false;
            v = computerScore + computerTotal;
            if (v >= win)
            {
                // Computer wins!
                gameOver = true;
                lblComputerTotal.Text = Convert.ToString(v);
                lblMessage.Text = "I win!!";
                btnStop.PerformClick();
                return;
            }
            else if (win - youTotal <= 10)
            {
                // If you are close to win, computer rolls again
                lblMessage.Text = "I'll roll again.";
                btnRoll_Click(null, null);
            }
            else
            {
                if (computerTotal >= youTotal)
                {
                    // If computer already ahead, less likely to roll again
                    odds = (int) (100 * ((double) computerScore) / 30.0);
                }
                else if (v < youTotal)
                {
                    // If computer behind, more likely
                    odds = (int) (100.0 * ((double)computerScore) / 50.0);
                }
                else
                {
                    odds = (int) (100.0 * ((double)computerScore) / 40.0);
                }
                if (myRandom.Next(100) > odds)
                {
                    lblMessage.Text = "I'll roll again.";
                    btnRoll_Click(null, null);
                }
                else
                {
                    // Stick with roll and pass
                    lblMessage.Text = "I pass to you.\r\nYour turn.";
                    computerScore = 0;
                    computerTotal = v;
                    lblComputerTotal.Text = Convert.ToString(computerTotal);
                    lblComputerScore.Text = "";
                    whoseTurn = 1;
                    btnRoll.Enabled = true;
                    btnRoll.Focus();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "Exit")
            {
                this.Close();
            }
            else
            {
                // Stop current game
                timComputer.Enabled = false;
                btnNew.Enabled = true;
                btnStop.Text = "Exit";
                btnRoll.Enabled = false;
                btnPass.Enabled = false;
                if (!gameOver)
                {
                    lblMessage.Text = "Game Stopped";
                }
                btnNew.Focus();
            }
        }
    }
}