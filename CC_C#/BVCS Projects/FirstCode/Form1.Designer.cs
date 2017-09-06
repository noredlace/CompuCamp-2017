namespace FirstCode
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
            this.btnBeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(96, 49);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 0;
            this.btnBeep.Text = "Beep!!";
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(291, 140);
            this.Controls.Add(this.btnBeep);
            this.Name = "Form1";
            this.Text = "My First Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeep;

    }
}

