namespace Decode
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpGuess = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpGuesses = new System.Windows.Forms.GroupBox();
            this.txtGuesses = new System.Windows.Forms.TextBox();
            this.grpGuess.SuspendLayout();
            this.grpGuesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage.Location = new System.Drawing.Point(11, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(200, 125);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpGuess
            // 
            this.grpGuess.BackColor = System.Drawing.Color.Red;
            this.grpGuess.Controls.Add(this.btnCheck);
            this.grpGuess.Controls.Add(this.txtGuess);
            this.grpGuess.Location = new System.Drawing.Point(11, 155);
            this.grpGuess.Name = "grpGuess";
            this.grpGuess.Size = new System.Drawing.Size(199, 84);
            this.grpGuess.TabIndex = 1;
            this.grpGuess.TabStop = false;
            this.grpGuess.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(23, 55);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(150, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Guess";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(23, 20);
            this.txtGuess.MaxLength = 4;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(150, 31);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(23, 246);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(125, 246);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpGuesses
            // 
            this.grpGuesses.BackColor = System.Drawing.Color.Red;
            this.grpGuesses.Controls.Add(this.txtGuesses);
            this.grpGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuesses.ForeColor = System.Drawing.Color.Yellow;
            this.grpGuesses.Location = new System.Drawing.Point(226, 13);
            this.grpGuesses.Name = "grpGuesses";
            this.grpGuesses.Size = new System.Drawing.Size(175, 255);
            this.grpGuesses.TabIndex = 4;
            this.grpGuesses.TabStop = false;
            this.grpGuesses.Text = "Your Guesses";
            // 
            // txtGuesses
            // 
            this.txtGuesses.BackColor = System.Drawing.Color.White;
            this.txtGuesses.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuesses.Location = new System.Drawing.Point(13, 26);
            this.txtGuesses.Multiline = true;
            this.txtGuesses.Name = "txtGuesses";
            this.txtGuesses.ReadOnly = true;
            this.txtGuesses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuesses.Size = new System.Drawing.Size(146, 223);
            this.txtGuesses.TabIndex = 0;
            this.txtGuesses.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(414, 278);
            this.Controls.Add(this.grpGuesses);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grpGuess);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGuess.ResumeLayout(false);
            this.grpGuess.PerformLayout();
            this.grpGuesses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpGuesses;
        private System.Windows.Forms.TextBox txtGuesses;
    }
}

