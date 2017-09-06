namespace Stopwatch
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
      this.txtTime = new System.Windows.Forms.TextBox();
      this.btnStartStop = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.timDisplay = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // txtTime
      // 
      this.txtTime.BackColor = System.Drawing.Color.White;
      this.txtTime.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTime.Location = new System.Drawing.Point(104, 5);
      this.txtTime.Multiline = true;
      this.txtTime.Name = "txtTime";
      this.txtTime.ReadOnly = true;
      this.txtTime.Size = new System.Drawing.Size(166, 47);
      this.txtTime.TabIndex = 0;
      this.txtTime.TabStop = false;
      this.txtTime.Text = "00:00:00";
      this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnStartStop
      // 
      this.btnStartStop.BackColor = System.Drawing.SystemColors.Control;
      this.btnStartStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartStop.Location = new System.Drawing.Point(135, 59);
      this.btnStartStop.Name = "btnStartStop";
      this.btnStartStop.Size = new System.Drawing.Size(101, 39);
      this.btnStartStop.TabIndex = 1;
      this.btnStartStop.Text = "Start";
      this.btnStartStop.UseVisualStyleBackColor = false;
      this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
      // 
      // btnReset
      // 
      this.btnReset.BackColor = System.Drawing.SystemColors.Control;
      this.btnReset.Enabled = false;
      this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.Location = new System.Drawing.Point(135, 105);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(101, 39);
      this.btnReset.TabIndex = 2;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = false;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // timDisplay
      // 
      this.timDisplay.Interval = 1000;
      this.timDisplay.Tick += new System.EventHandler(this.timDisplay_Tick);
      // 
      // Form1
      // 
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(352, 156);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnStartStop);
      this.Controls.Add(this.txtTime);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stopwatch";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timDisplay;
    }
}

