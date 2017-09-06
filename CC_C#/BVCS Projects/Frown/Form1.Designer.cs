namespace Frown
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYouTotal = new System.Windows.Forms.Label();
            this.lblYouScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpComputer = new System.Windows.Forms.GroupBox();
            this.lblComputerTotal = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlDice = new System.Windows.Forms.Panel();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timComputer = new System.Windows.Forms.Timer(this.components);
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDots6 = new System.Windows.Forms.PictureBox();
            this.picDots5 = new System.Windows.Forms.PictureBox();
            this.picDots4 = new System.Windows.Forms.PictureBox();
            this.picDots3 = new System.Windows.Forms.PictureBox();
            this.picDots2 = new System.Windows.Forms.PictureBox();
            this.picDots1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpComputer.SuspendLayout();
            this.pnlDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.lblYouTotal);
            this.groupBox1.Controls.Add(this.lblYouScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You";
            // 
            // lblYouTotal
            // 
            this.lblYouTotal.BackColor = System.Drawing.Color.White;
            this.lblYouTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYouTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouTotal.ForeColor = System.Drawing.Color.Black;
            this.lblYouTotal.Location = new System.Drawing.Point(129, 60);
            this.lblYouTotal.Name = "lblYouTotal";
            this.lblYouTotal.Size = new System.Drawing.Size(65, 25);
            this.lblYouTotal.TabIndex = 3;
            this.lblYouTotal.Text = "0";
            this.lblYouTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYouScore
            // 
            this.lblYouScore.BackColor = System.Drawing.Color.White;
            this.lblYouScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYouScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouScore.ForeColor = System.Drawing.Color.Black;
            this.lblYouScore.Location = new System.Drawing.Point(129, 20);
            this.lblYouScore.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblYouScore.Name = "lblYouScore";
            this.lblYouScore.Size = new System.Drawing.Size(65, 25);
            this.lblYouScore.TabIndex = 2;
            this.lblYouScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score This Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpComputer
            // 
            this.grpComputer.BackColor = System.Drawing.Color.Blue;
            this.grpComputer.Controls.Add(this.lblComputerTotal);
            this.grpComputer.Controls.Add(this.lblComputerScore);
            this.grpComputer.Controls.Add(this.label5);
            this.grpComputer.Controls.Add(this.label6);
            this.grpComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpComputer.ForeColor = System.Drawing.Color.Yellow;
            this.grpComputer.Location = new System.Drawing.Point(13, 116);
            this.grpComputer.Name = "grpComputer";
            this.grpComputer.Size = new System.Drawing.Size(209, 96);
            this.grpComputer.TabIndex = 1;
            this.grpComputer.TabStop = false;
            this.grpComputer.Text = "Computer";
            // 
            // lblComputerTotal
            // 
            this.lblComputerTotal.BackColor = System.Drawing.Color.White;
            this.lblComputerTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerTotal.ForeColor = System.Drawing.Color.Black;
            this.lblComputerTotal.Location = new System.Drawing.Point(129, 56);
            this.lblComputerTotal.Name = "lblComputerTotal";
            this.lblComputerTotal.Size = new System.Drawing.Size(65, 25);
            this.lblComputerTotal.TabIndex = 3;
            this.lblComputerTotal.Text = "0";
            this.lblComputerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.BackColor = System.Drawing.Color.White;
            this.lblComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.Black;
            this.lblComputerScore.Location = new System.Drawing.Point(129, 20);
            this.lblComputerScore.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(65, 25);
            this.lblComputerScore.TabIndex = 2;
            this.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Score This Turn";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(30, 219);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 25);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Location = new System.Drawing.Point(128, 219);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 25);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Exit";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlDice
            // 
            this.pnlDice.BackColor = System.Drawing.Color.Red;
            this.pnlDice.Controls.Add(this.btnPass);
            this.pnlDice.Controls.Add(this.btnRoll);
            this.pnlDice.Controls.Add(this.picDice2);
            this.pnlDice.Controls.Add(this.picDice1);
            this.pnlDice.Controls.Add(this.lblMessage);
            this.pnlDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDice.ForeColor = System.Drawing.Color.Black;
            this.pnlDice.Location = new System.Drawing.Point(229, 13);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(219, 231);
            this.pnlDice.TabIndex = 4;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPass.Enabled = false;
            this.btnPass.Location = new System.Drawing.Point(117, 197);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(87, 29);
            this.btnPass.TabIndex = 4;
            this.btnPass.Text = "Pass Dice";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRoll.Enabled = false;
            this.btnRoll.Location = new System.Drawing.Point(12, 197);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(87, 29);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 8);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(198, 77);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timComputer
            // 
            this.timComputer.Interval = 2000;
            this.timComputer.Tick += new System.EventHandler(this.timComputer_Tick);
            // 
            // picDice2
            // 
            this.picDice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picDice2.Location = new System.Drawing.Point(117, 100);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(90, 90);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 2;
            this.picDice2.TabStop = false;
            // 
            // picDice1
            // 
            this.picDice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picDice1.Location = new System.Drawing.Point(9, 100);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(90, 90);
            this.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice1.TabIndex = 1;
            this.picDice1.TabStop = false;
            // 
            // picDots6
            // 
            this.picDots6.Image = global::Frown.Properties.Resources.DICE6;
            this.picDots6.Location = new System.Drawing.Point(185, 212);
            this.picDots6.Name = "picDots6";
            this.picDots6.Size = new System.Drawing.Size(24, 20);
            this.picDots6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots6.TabIndex = 10;
            this.picDots6.TabStop = false;
            this.picDots6.Visible = false;
            // 
            // picDots5
            // 
            this.picDots5.Image = global::Frown.Properties.Resources.DICE5;
            this.picDots5.Location = new System.Drawing.Point(154, 212);
            this.picDots5.Name = "picDots5";
            this.picDots5.Size = new System.Drawing.Size(24, 20);
            this.picDots5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots5.TabIndex = 9;
            this.picDots5.TabStop = false;
            this.picDots5.Visible = false;
            // 
            // picDots4
            // 
            this.picDots4.Image = global::Frown.Properties.Resources.DICE4;
            this.picDots4.Location = new System.Drawing.Point(123, 212);
            this.picDots4.Name = "picDots4";
            this.picDots4.Size = new System.Drawing.Size(24, 20);
            this.picDots4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots4.TabIndex = 8;
            this.picDots4.TabStop = false;
            this.picDots4.Visible = false;
            // 
            // picDots3
            // 
            this.picDots3.Image = global::Frown.Properties.Resources.DICE3;
            this.picDots3.Location = new System.Drawing.Point(92, 212);
            this.picDots3.Name = "picDots3";
            this.picDots3.Size = new System.Drawing.Size(24, 20);
            this.picDots3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots3.TabIndex = 7;
            this.picDots3.TabStop = false;
            this.picDots3.Visible = false;
            // 
            // picDots2
            // 
            this.picDots2.Image = global::Frown.Properties.Resources.DICE2;
            this.picDots2.Location = new System.Drawing.Point(61, 212);
            this.picDots2.Name = "picDots2";
            this.picDots2.Size = new System.Drawing.Size(24, 20);
            this.picDots2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots2.TabIndex = 6;
            this.picDots2.TabStop = false;
            this.picDots2.Visible = false;
            // 
            // picDots1
            // 
            this.picDots1.Image = global::Frown.Properties.Resources.FROWN;
            this.picDots1.Location = new System.Drawing.Point(30, 212);
            this.picDots1.Name = "picDots1";
            this.picDots1.Size = new System.Drawing.Size(24, 20);
            this.picDots1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDots1.TabIndex = 5;
            this.picDots1.TabStop = false;
            this.picDots1.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 251);
            this.Controls.Add(this.pnlDice);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grpComputer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDots6);
            this.Controls.Add(this.picDots5);
            this.Controls.Add(this.picDots4);
            this.Controls.Add(this.picDots3);
            this.Controls.Add(this.picDots2);
            this.Controls.Add(this.picDots1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpComputer.ResumeLayout(false);
            this.grpComputer.PerformLayout();
            this.pnlDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDots1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYouScore;
        private System.Windows.Forms.Label lblYouTotal;
        private System.Windows.Forms.GroupBox grpComputer;
        private System.Windows.Forms.Label lblComputerTotal;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlDice;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.PictureBox picDots1;
        private System.Windows.Forms.PictureBox picDots2;
        private System.Windows.Forms.PictureBox picDots3;
        private System.Windows.Forms.PictureBox picDots4;
        private System.Windows.Forms.PictureBox picDots5;
        private System.Windows.Forms.PictureBox picDots6;
        private System.Windows.Forms.Timer timComputer;
    }
}

