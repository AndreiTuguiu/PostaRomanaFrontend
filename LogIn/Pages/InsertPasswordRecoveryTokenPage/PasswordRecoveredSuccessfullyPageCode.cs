using LogIn.Pages.CreateNewPassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
public System.Windows.Forms.FormBorderStyle FormBorderStyle { get; set; }

namespace LogIn.Pages.PasswordRecoveredSuccessfullyPage
{
    public partial class PasswordRecoveredSuccessfullyPageCode : Form
    {
        public PasswordRecoveredSuccessfullyPageCode()
        {
            InitializeComponent();
        }

        private void label_passRecSucc_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_recover_sendCode_Click(object sender, EventArgs e)
        {
            //if textbox token == database token then goto createnewpasswordPage
            if (textBox1.Text == "token")
            {
                label1.Visible = true;

                var frm = new CreateNewPasswordPage();

                Location = this.Location;
                StartPosition = FormStartPosition.Manual;

                //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
                frm.Show();
                //Thread.Sleep(1000);
                this.Hide();
            }
            else
            {
                label1.Visible = true;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_recover_sendCode_Click(sender, e);
            }
        }

        private void PasswordRecoveredSuccessfullyPageCode_Load(object sender, EventArgs e)
        {

        }
    }
}
