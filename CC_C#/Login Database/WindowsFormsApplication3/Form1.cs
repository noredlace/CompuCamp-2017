using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] user = new string[100];
        string[] pass = new string[100];
        int count;
        bool loginYes;
        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
            loginYes = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "";
            user[count] = txtUserReg.Text;
            pass[count] = txtPassReg.Text;
            count++;

            //display info to me
            for (int i = 0; i < count; i++) { 
            txtInfo.Text = txtInfo.Text + (string)user[i] + " " + (string)pass[i] + "\r\n";
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++) {
                if ((string)txtUser.Text == (string)user[i] && (string)txtPass.Text == (string)pass[i])
                {
                    loginYes = true;
                }
            }
            if (loginYes == true)
            {
                txtOutput.Text = "Yes";
            }
            else {
                txtOutput.Text = "No";
            }
        }
    }
}
