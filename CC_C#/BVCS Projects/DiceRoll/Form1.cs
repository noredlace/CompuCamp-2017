#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DiceRoll
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image[] dots = new Image[6];
        Random myRandom = new Random();

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Roll Dice 1 and set display
            picDice1.Image = dots[myRandom.Next(6)];
            // Roll Dice 2 and set display
            picDice2.Image = dots[myRandom.Next(6)];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize display
            dots[0] = picDots1.Image;
            dots[1] = picDots2.Image;
            dots[2] = picDots3.Image;
            dots[3] = picDots4.Image;
            dots[4] = picDots5.Image;
            dots[5] = picDots6.Image;
            btnRoll.PerformClick();
        }
    }
}