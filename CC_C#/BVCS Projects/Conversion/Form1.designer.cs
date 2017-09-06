namespace Conversion
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
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.txtToValue = new System.Windows.Forms.TextBox();
            this.dudFromUnit = new System.Windows.Forms.DomainUpDown();
            this.dudToUnit = new System.Windows.Forms.DomainUpDown();
            this.grpConvert = new System.Windows.Forms.GroupBox();
            this.rdoDec5 = new System.Windows.Forms.RadioButton();
            this.rdoDec4 = new System.Windows.Forms.RadioButton();
            this.rdoDec3 = new System.Windows.Forms.RadioButton();
            this.rdoDec2 = new System.Windows.Forms.RadioButton();
            this.rdoDec1 = new System.Windows.Forms.RadioButton();
            this.rdoDec0 = new System.Windows.Forms.RadioButton();
            this.grpConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFromValue
            // 
            this.txtFromValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromValue.Location = new System.Drawing.Point(12, 16);
            this.txtFromValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(112, 26);
            this.txtFromValue.TabIndex = 0;
            this.txtFromValue.Text = "0";
            this.txtFromValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFromValue.TextChanged += new System.EventHandler(this.txtFromValue_TextChanged);
            this.txtFromValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromValue_KeyPress);
            // 
            // txtToValue
            // 
            this.txtToValue.BackColor = System.Drawing.Color.White;
            this.txtToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToValue.Location = new System.Drawing.Point(13, 43);
            this.txtToValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtToValue.Name = "txtToValue";
            this.txtToValue.ReadOnly = true;
            this.txtToValue.Size = new System.Drawing.Size(111, 26);
            this.txtToValue.TabIndex = 1;
            this.txtToValue.TabStop = false;
            this.txtToValue.Text = "0";
            this.txtToValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dudFromUnit
            // 
            this.dudFromUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dudFromUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudFromUnit.Location = new System.Drawing.Point(131, 15);
            this.dudFromUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.dudFromUnit.Name = "dudFromUnit";
            this.dudFromUnit.ReadOnly = true;
            this.dudFromUnit.Size = new System.Drawing.Size(161, 26);
            this.dudFromUnit.TabIndex = 2;
            this.dudFromUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dudFromUnit.SelectedItemChanged += new System.EventHandler(this.dudFromUnit_SelectedItemChanged);
            // 
            // dudToUnit
            // 
            this.dudToUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dudToUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudToUnit.Location = new System.Drawing.Point(131, 43);
            this.dudToUnit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.dudToUnit.Name = "dudToUnit";
            this.dudToUnit.ReadOnly = true;
            this.dudToUnit.Size = new System.Drawing.Size(160, 26);
            this.dudToUnit.TabIndex = 3;
            this.dudToUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dudToUnit.SelectedItemChanged += new System.EventHandler(this.dudToUnit_SelectedItemChanged);
            // 
            // grpConvert
            // 
            this.grpConvert.BackColor = System.Drawing.SystemColors.Control;
            this.grpConvert.Controls.Add(this.rdoDec5);
            this.grpConvert.Controls.Add(this.rdoDec4);
            this.grpConvert.Controls.Add(this.rdoDec3);
            this.grpConvert.Controls.Add(this.rdoDec2);
            this.grpConvert.Controls.Add(this.rdoDec1);
            this.grpConvert.Controls.Add(this.rdoDec0);
            this.grpConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConvert.Location = new System.Drawing.Point(65, 76);
            this.grpConvert.Name = "grpConvert";
            this.grpConvert.Size = new System.Drawing.Size(177, 100);
            this.grpConvert.TabIndex = 4;
            this.grpConvert.TabStop = false;
            this.grpConvert.Text = "Number of Decimals";
            // 
            // rdoDec5
            // 
            this.rdoDec5.AutoSize = true;
            this.rdoDec5.Location = new System.Drawing.Point(105, 70);
            this.rdoDec5.Name = "rdoDec5";
            this.rdoDec5.Size = new System.Drawing.Size(33, 20);
            this.rdoDec5.TabIndex = 5;
            this.rdoDec5.Text = "5";
            this.rdoDec5.CheckedChanged += new System.EventHandler(this.rdoDec5_CheckedChanged);
            // 
            // rdoDec4
            // 
            this.rdoDec4.AutoSize = true;
            this.rdoDec4.Location = new System.Drawing.Point(105, 46);
            this.rdoDec4.Name = "rdoDec4";
            this.rdoDec4.Size = new System.Drawing.Size(33, 20);
            this.rdoDec4.TabIndex = 4;
            this.rdoDec4.Text = "4";
            this.rdoDec4.CheckedChanged += new System.EventHandler(this.rdoDec4_CheckedChanged);
            // 
            // rdoDec3
            // 
            this.rdoDec3.AutoSize = true;
            this.rdoDec3.Location = new System.Drawing.Point(105, 22);
            this.rdoDec3.Name = "rdoDec3";
            this.rdoDec3.Size = new System.Drawing.Size(33, 20);
            this.rdoDec3.TabIndex = 3;
            this.rdoDec3.Text = "3";
            this.rdoDec3.CheckedChanged += new System.EventHandler(this.rdoDec3_CheckedChanged);
            // 
            // rdoDec2
            // 
            this.rdoDec2.AutoSize = true;
            this.rdoDec2.Location = new System.Drawing.Point(45, 70);
            this.rdoDec2.Name = "rdoDec2";
            this.rdoDec2.Size = new System.Drawing.Size(33, 20);
            this.rdoDec2.TabIndex = 2;
            this.rdoDec2.Text = "2";
            this.rdoDec2.CheckedChanged += new System.EventHandler(this.rdoDec2_CheckedChanged);
            // 
            // rdoDec1
            // 
            this.rdoDec1.AutoSize = true;
            this.rdoDec1.Location = new System.Drawing.Point(45, 46);
            this.rdoDec1.Name = "rdoDec1";
            this.rdoDec1.Size = new System.Drawing.Size(33, 20);
            this.rdoDec1.TabIndex = 1;
            this.rdoDec1.Text = "1";
            this.rdoDec1.CheckedChanged += new System.EventHandler(this.rdoDec1_CheckedChanged);
            // 
            // rdoDec0
            // 
            this.rdoDec0.AutoSize = true;
            this.rdoDec0.Checked = true;
            this.rdoDec0.Location = new System.Drawing.Point(45, 22);
            this.rdoDec0.Name = "rdoDec0";
            this.rdoDec0.Size = new System.Drawing.Size(33, 20);
            this.rdoDec0.TabIndex = 0;
            this.rdoDec0.TabStop = true;
            this.rdoDec0.Text = "0";
            this.rdoDec0.CheckedChanged += new System.EventHandler(this.rdoDec0_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 188);
            this.Controls.Add(this.grpConvert);
            this.Controls.Add(this.dudToUnit);
            this.Controls.Add(this.dudFromUnit);
            this.Controls.Add(this.txtToValue);
            this.Controls.Add(this.txtFromValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpConvert.ResumeLayout(false);
            this.grpConvert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromValue;
        private System.Windows.Forms.TextBox txtToValue;
        private System.Windows.Forms.DomainUpDown dudFromUnit;
        private System.Windows.Forms.DomainUpDown dudToUnit;
        private System.Windows.Forms.GroupBox grpConvert;
        private System.Windows.Forms.RadioButton rdoDec0;
        private System.Windows.Forms.RadioButton rdoDec1;
        private System.Windows.Forms.RadioButton rdoDec2;
        private System.Windows.Forms.RadioButton rdoDec3;
        private System.Windows.Forms.RadioButton rdoDec4;
        private System.Windows.Forms.RadioButton rdoDec5;

    }
}

