using LogIn.Pages.PasswordRecoveredSuccessfullyPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostaRomana.RecoverPasswordPage
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_login_username_Click(object sender, EventArgs e)
        {

        }

        private void bt_recover_sendCode_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                label_recover_invalidEmail.Visible = true;
                //
                // tabel nou sau field nou la user numit passwordRecoveryToken
                // backend.verifytoken returneaza bool 1 daca matchuieste
                // daca returneaza 1 
                //
                //
                //
                //

            }
            else
            {
                label_recover_invalidEmail.Visible = false;
                var frm = new PasswordRecoveredSuccessfullyPageCode();

                Location = this.Location;
                StartPosition = FormStartPosition.Manual;

                //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
                frm.Show();
                //Thread.Sleep(1000);
                this.Hide();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_recover_sendCode_Click(sender, e);
            }
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_recover_sendCode_Click(sender, e);
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       

        

        
    }

