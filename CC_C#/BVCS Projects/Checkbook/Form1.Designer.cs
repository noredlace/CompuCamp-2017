namespace Checkbook
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
            this.btnStmtBalance = new System.Windows.Forms.Button();
            this.btnStmtDeposit = new System.Windows.Forms.Button();
            this.btnStmtCheck = new System.Windows.Forms.Button();
            this.btnStmtReset = new System.Windows.Forms.Button();
            this.btnChkBalance = new System.Windows.Forms.Button();
            this.btnChkDeposit = new System.Windows.Forms.Button();
            this.btnChkCharge = new System.Windows.Forms.Button();
            this.btnChkReset = new System.Windows.Forms.Button();
            this.txtStmtBalance = new System.Windows.Forms.TextBox();
            this.txtStmtDeposit = new System.Windows.Forms.TextBox();
            this.txtStmtCheck = new System.Windows.Forms.TextBox();
            this.txtChkBalance = new System.Windows.Forms.TextBox();
            this.txtAdjChkBalance = new System.Windows.Forms.TextBox();
            this.txtAdjStmtBalance = new System.Windows.Forms.TextBox();
            this.txtChkCharge = new System.Windows.Forms.TextBox();
            this.txtChkDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStmtBalance
            // 
            this.btnStmtBalance.BackColor = System.Drawing.SystemColors.Control;
            this.btnStmtBalance.Location = new System.Drawing.Point(10, 9);
            this.btnStmtBalance.Name = "btnStmtBalance";
            this.btnStmtBalance.Size = new System.Drawing.Size(131, 52);
            this.btnStmtBalance.TabIndex = 0;
            this.btnStmtBalance.Text = "Enter Statement Balance";
            this.btnStmtBalance.UseVisualStyleBackColor = false;
            this.btnStmtBalance.Click += new System.EventHandler(this.btnStmtBalance_Click);
            // 
            // btnStmtDeposit
            // 
            this.btnStmtDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnStmtDeposit.Enabled = false;
            this.btnStmtDeposit.Location = new System.Drawing.Point(10, 68);
            this.btnStmtDeposit.Name = "btnStmtDeposit";
            this.btnStmtDeposit.Size = new System.Drawing.Size(131, 52);
            this.btnStmtDeposit.TabIndex = 1;
            this.btnStmtDeposit.Text = "Add Uncredited Deposit";
            this.btnStmtDeposit.UseVisualStyleBackColor = false;
            this.btnStmtDeposit.Click += new System.EventHandler(this.btnStmtDeposit_Click);
            // 
            // btnStmtCheck
            // 
            this.btnStmtCheck.BackColor = System.Drawing.SystemColors.Control;
            this.btnStmtCheck.Enabled = false;
            this.btnStmtCheck.Location = new System.Drawing.Point(10, 127);
            this.btnStmtCheck.Name = "btnStmtCheck";
            this.btnStmtCheck.Size = new System.Drawing.Size(131, 52);
            this.btnStmtCheck.TabIndex = 2;
            this.btnStmtCheck.Text = "Subtract Outstanding Check";
            this.btnStmtCheck.UseVisualStyleBackColor = false;
            this.btnStmtCheck.Click += new System.EventHandler(this.btnStmtCheck_Click);
            // 
            // btnStmtReset
            // 
            this.btnStmtReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnStmtReset.Location = new System.Drawing.Point(81, 222);
            this.btnStmtReset.Name = "btnStmtReset";
            this.btnStmtReset.Size = new System.Drawing.Size(131, 52);
            this.btnStmtReset.TabIndex = 3;
            this.btnStmtReset.Text = "Reset Statement Values";
            this.btnStmtReset.UseVisualStyleBackColor = false;
            this.btnStmtReset.Click += new System.EventHandler(this.btnStmtReset_Click);
            // 
            // btnChkBalance
            // 
            this.btnChkBalance.BackColor = System.Drawing.SystemColors.Control;
            this.btnChkBalance.Location = new System.Drawing.Point(391, 9);
            this.btnChkBalance.Name = "btnChkBalance";
            this.btnChkBalance.Size = new System.Drawing.Size(131, 52);
            this.btnChkBalance.TabIndex = 4;
            this.btnChkBalance.Text = "Enter Checkbook Balance";
            this.btnChkBalance.UseVisualStyleBackColor = false;
            this.btnChkBalance.Click += new System.EventHandler(this.btnChkBalance_Click);
            // 
            // btnChkDeposit
            // 
            this.btnChkDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnChkDeposit.Enabled = false;
            this.btnChkDeposit.Location = new System.Drawing.Point(391, 68);
            this.btnChkDeposit.Name = "btnChkDeposit";
            this.btnChkDeposit.Size = new System.Drawing.Size(131, 52);
            this.btnChkDeposit.TabIndex = 5;
            this.btnChkDeposit.Text = "Add Unrecorded Deposit";
            this.btnChkDeposit.UseVisualStyleBackColor = false;
            this.btnChkDeposit.Click += new System.EventHandler(this.btnChkDeposit_Click);
            // 
            // btnChkCharge
            // 
            this.btnChkCharge.BackColor = System.Drawing.SystemColors.Control;
            this.btnChkCharge.Enabled = false;
            this.btnChkCharge.Location = new System.Drawing.Point(391, 127);
            this.btnChkCharge.Name = "btnChkCharge";
            this.btnChkCharge.Size = new System.Drawing.Size(131, 52);
            this.btnChkCharge.TabIndex = 6;
            this.btnChkCharge.Text = "Subtract Service Charge";
            this.btnChkCharge.UseVisualStyleBackColor = false;
            this.btnChkCharge.Click += new System.EventHandler(this.btnChkCharge_Click);
            // 
            // btnChkReset
            // 
            this.btnChkReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnChkReset.Location = new System.Drawing.Point(327, 222);
            this.btnChkReset.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnChkReset.Name = "btnChkReset";
            this.btnChkReset.Size = new System.Drawing.Size(131, 52);
            this.btnChkReset.TabIndex = 7;
            this.btnChkReset.Text = "Reset Checkbook Values";
            this.btnChkReset.UseVisualStyleBackColor = false;
            this.btnChkReset.Click += new System.EventHandler(this.btnChkReset_Click);
            // 
            // txtStmtBalance
            // 
            this.txtStmtBalance.Location = new System.Drawing.Point(148, 9);
            this.txtStmtBalance.Name = "txtStmtBalance";
            this.txtStmtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtStmtBalance.TabIndex = 8;
            this.txtStmtBalance.Text = "0";
            this.txtStmtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStmtDeposit
            // 
            this.txtStmtDeposit.BackColor = System.Drawing.Color.White;
            this.txtStmtDeposit.Location = new System.Drawing.Point(148, 68);
            this.txtStmtDeposit.Name = "txtStmtDeposit";
            this.txtStmtDeposit.ReadOnly = true;
            this.txtStmtDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtStmtDeposit.TabIndex = 9;
            this.txtStmtDeposit.TabStop = false;
            this.txtStmtDeposit.Text = "0";
            this.txtStmtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStmtCheck
            // 
            this.txtStmtCheck.BackColor = System.Drawing.Color.White;
            this.txtStmtCheck.Location = new System.Drawing.Point(148, 127);
            this.txtStmtCheck.Name = "txtStmtCheck";
            this.txtStmtCheck.ReadOnly = true;
            this.txtStmtCheck.Size = new System.Drawing.Size(100, 20);
            this.txtStmtCheck.TabIndex = 10;
            this.txtStmtCheck.TabStop = false;
            this.txtStmtCheck.Text = "0";
            this.txtStmtCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChkBalance
            // 
            this.txtChkBalance.Location = new System.Drawing.Point(284, 9);
            this.txtChkBalance.Name = "txtChkBalance";
            this.txtChkBalance.Size = new System.Drawing.Size(100, 20);
            this.txtChkBalance.TabIndex = 11;
            this.txtChkBalance.Text = "0";
            this.txtChkBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdjChkBalance
            // 
            this.txtAdjChkBalance.BackColor = System.Drawing.Color.White;
            this.txtAdjChkBalance.Location = new System.Drawing.Point(284, 188);
            this.txtAdjChkBalance.Name = "txtAdjChkBalance";
            this.txtAdjChkBalance.ReadOnly = true;
            this.txtAdjChkBalance.Size = new System.Drawing.Size(100, 20);
            this.txtAdjChkBalance.TabIndex = 12;
            this.txtAdjChkBalance.TabStop = false;
            this.txtAdjChkBalance.Text = "0";
            this.txtAdjChkBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdjStmtBalance
            // 
            this.txtAdjStmtBalance.BackColor = System.Drawing.Color.White;
            this.txtAdjStmtBalance.Location = new System.Drawing.Point(148, 188);
            this.txtAdjStmtBalance.Name = "txtAdjStmtBalance";
            this.txtAdjStmtBalance.ReadOnly = true;
            this.txtAdjStmtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtAdjStmtBalance.TabIndex = 13;
            this.txtAdjStmtBalance.TabStop = false;
            this.txtAdjStmtBalance.Text = "0";
            this.txtAdjStmtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChkCharge
            // 
            this.txtChkCharge.BackColor = System.Drawing.Color.White;
            this.txtChkCharge.Location = new System.Drawing.Point(284, 127);
            this.txtChkCharge.Name = "txtChkCharge";
            this.txtChkCharge.ReadOnly = true;
            this.txtChkCharge.Size = new System.Drawing.Size(100, 20);
            this.txtChkCharge.TabIndex = 14;
            this.txtChkCharge.TabStop = false;
            this.txtChkCharge.Text = "0";
            this.txtChkCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChkDeposit
            // 
            this.txtChkDeposit.BackColor = System.Drawing.Color.White;
            this.txtChkDeposit.Location = new System.Drawing.Point(284, 68);
            this.txtChkDeposit.Name = "txtChkDeposit";
            this.txtChkDeposit.ReadOnly = true;
            this.txtChkDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtChkDeposit.TabIndex = 15;
            this.txtChkDeposit.TabStop = false;
            this.txtChkDeposit.Text = "0";
            this.txtChkDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adjusted Statement Balance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(391, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adjusted Checkbook Balance";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 265);
            this.label3.TabIndex = 18;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChkDeposit);
            this.Controls.Add(this.txtChkCharge);
            this.Controls.Add(this.txtAdjStmtBalance);
            this.Controls.Add(this.txtAdjChkBalance);
            this.Controls.Add(this.txtChkBalance);
            this.Controls.Add(this.txtStmtCheck);
            this.Controls.Add(this.txtStmtDeposit);
            this.Controls.Add(this.txtStmtBalance);
            this.Controls.Add(this.btnChkReset);
            this.Controls.Add(this.btnChkCharge);
            this.Controls.Add(this.btnChkDeposit);
            this.Controls.Add(this.btnChkBalance);
            this.Controls.Add(this.btnStmtReset);
            this.Controls.Add(this.btnStmtCheck);
            this.Controls.Add(this.btnStmtDeposit);
            this.Controls.Add(this.btnStmtBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkbook Balancer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStmtBalance;
        private System.Windows.Forms.Button btnStmtDeposit;
        private System.Windows.Forms.Button btnStmtCheck;
        private System.Windows.Forms.Button btnStmtReset;
        private System.Windows.Forms.Button btnChkBalance;
        private System.Windows.Forms.Button btnChkDeposit;
        private System.Windows.Forms.Button btnChkCharge;
        private System.Windows.Forms.Button btnChkReset;
        private System.Windows.Forms.TextBox txtStmtBalance;
        private System.Windows.Forms.TextBox txtStmtDeposit;
        private System.Windows.Forms.TextBox txtStmtCheck;
        private System.Windows.Forms.TextBox txtChkBalance;
        private System.Windows.Forms.TextBox txtAdjChkBalance;
        private System.Windows.Forms.TextBox txtAdjStmtBalance;
        private System.Windows.Forms.TextBox txtChkCharge;
        private System.Windows.Forms.TextBox txtChkDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

