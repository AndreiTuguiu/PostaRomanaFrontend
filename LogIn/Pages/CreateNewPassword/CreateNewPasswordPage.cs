using LogIn.Pages.PasswordRecoveredSuccessfullyPage;
using PostaRomana.LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn.Pages.CreateNewPassword
{
    public partial class CreateNewPasswordPage : Form
    {
        public CreateNewPasswordPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '•') textBox2.PasswordChar = default;
            else textBox2.PasswordChar = '•';
        }

        private void button_login_showPassword_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '•') textBox1.PasswordChar = default;
            else textBox1.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != textBox2.Text)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                button3.Visible = true;
                label4.Visible = true;
                button3.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new LoginMainPage();

            Location = this.Location;
            StartPosition = FormStartPosition.Manual;

            //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
            frm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text && textBox2.Text.Length > 0)
                label3.Visible = true;
            else label3.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text && textBox2.Text.Length > 0)
                label3.Visible = true;
            else label3.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
