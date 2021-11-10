using LogIn.Actions;
using PostaRomana.MainPage;
using PostaRomana.RecoverPasswordPage;
using PostaRomanaFrontend.SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostaRomana.LogIn
{
    public partial class LoginMainPage : Form
    {
        static HttpClient client = new HttpClient();
        
        public LoginMainPage()
        {
            DateTime FourSecondsLater = DateTime.Now.AddSeconds(4);
            InitializeComponent();

            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public class ToSend
        {
            //public string fullName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            //public string email { get; set; }
        }

        /*private async Task<HttpResponseMessage> GetAMessageAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/Event/ListOfCountries");
            return response;
        }*/
        DateTime FourSecondsLater = DateTime.Now.AddSeconds(4);

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

        private async void bt_login_LogInButton_Click(object sender, EventArgs e)
        {
            /*            var toSend = new ToSend()
                        {
                            //fullName = tb_FirstName.Text.Trim() + " " + tb_LastName.Text.Trim(),
                            Username = textBox1.Text,
                            Password = textBox2.Text
                            //email = tb_Email.Text.Trim()
                        };

                        HttpResponseMessage response = await client.GetAsync($"api/Account/LogTheUser?Username={toSend.Username}?Password={toSend.Password}");

                        //if parola and username are leo and parola123 login, else
                        if (response.IsSuccessStatusCode)

                            *//*
                              //send textBox1 and textBox2 to httpPost LogTheUser (Compare credentials + Create Session)
                              //if LogIn returns not null (the session ValidTo)
                              save ValidTo in a variable for the timer
                            *//*
                        {
                            MainPage.MainPage frm = new MainPage.MainPage();


                            Location = this.Location;
                            StartPosition = FormStartPosition.Manual;

                            //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            label_login_placeholderSuccessfullyLoggedIn.Visible = false;
                            label_login_invalidUsername.Visible = true;
                        }*/
            await LoginOperation();
        }
        private async Task LoginOperation()
        {
            var toSend = new ToSend()
            {
                //fullName = tb_FirstName.Text.Trim() + " " + tb_LastName.Text.Trim(),
                Username = textBox1.Text,
                Password = textBox2.Text
                //email = tb_Email.Text.Trim()
            };
            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://localhost:5001/api/Account/LogTheUser?Username={toSend.Username}&Password={toSend.Password}");

                //if parola and username are leo and parola123 login, else
                if (response.IsSuccessStatusCode)

                /*
                  //send textBox1 and textBox2 to httpPost LogTheUser (Compare credentials + Create Session)
                  //if LogIn returns not null (the session ValidTo)
                  save ValidTo in a variable for the timer
                */
                {
                    MainPage.MainPage frm = new MainPage.MainPage();


                    Location = this.Location;
                    StartPosition = FormStartPosition.Manual;

                    //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    label_login_placeholderSuccessfullyLoggedIn.Visible = false;
                    label_login_invalidUsername.Visible = true;
                }
            }catch(Exception e)
            {
                MessageBox.Show("Invalid credentials");
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
            MainPage.MainPage frm = new MainPage.MainPage();

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

/*        private async void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await bt_login_LogInButton_Click(sender, e);
            }
        }*/

        //public class ModelJson(){}
        
        

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            SessionChecker.CheckSessionValidity(FourSecondsLater);
        }

        private void linkLabel_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CredentialsSignUp cSignUp = new CredentialsSignUp();
            cSignUp.Show();
        }
    }
}
