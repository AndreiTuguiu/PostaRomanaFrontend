using Microsoft.VisualBasic.ApplicationServices;
using PostaRomana.MainPage;
using PostaRomana.RecoverPasswordPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostaRomana.LogIn
{
    public partial class LoginMainPage : Form
    {
        public LoginMainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox remember password todo
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                bt_login_LogInButton_Click(sender, e);
            }

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginMainPage_Click(object sender, EventArgs e)
        {

        }

        private void bt_login_LogInButton_Click(object sender, EventArgs e)
        {


            //if parola and username are leo and parola123 login, else
            if (this.textBox1.Text == "Leo" && this.textBox2.Text == "Parola")
            { //test moving view to mainpage here
                var frm = new MainPageCode();

                Location = this.Location;
                StartPosition = FormStartPosition.Manual;

                //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
                frm.Show();
                //Thread.Sleep(1000);
                this.Hide();
            }
            else
            {
                label_login_placeholderSuccessfullyLoggedIn.Visible = false;
                label_login_invalidUsername.Visible = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '•') textBox2.PasswordChar = default;
            else textBox2.PasswordChar = '•';
        }

        private void LoginMainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //test moving view to mainpage here
            var frm = new MainPageCode();

            Location = this.Location;
            StartPosition = FormStartPosition.Manual;

            //rm.FormClosing += delegate { this.Show(); }; atunci cand inchid main page deschide login
            frm.Show();
            this.Hide();
        }

        private void linkLabel_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //todo link to recoverPassword page
            var frm = new RecoverPassword();

            Location = this.Location;
            StartPosition = FormStartPosition.Manual;

            //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
            frm.Show();
            //Thread.Sleep(1000);
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void checkbox_login_rememberPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            { if (this.checkbox_login_rememberPassword.Checked == true)
                    this.checkbox_login_rememberPassword.Checked = false;
                else
              if (this.checkbox_login_rememberPassword.Checked == false)
                    this.checkbox_login_rememberPassword.Checked = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login_LogInButton_Click(sender, e);
            }
        }

        //public class ModelJson(){}
        
        private void button_actuallogin_Click(object sender, EventArgs e)
        {
            var toSend = "test";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.PostAsJsonAsync("https://localhost:5001/api/User/CreateUser", toSend);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
