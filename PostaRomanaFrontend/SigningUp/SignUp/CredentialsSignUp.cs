﻿using LogIn.Actions;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PostaRomanaFrontend.SignUp
{
    public partial class CredentialsSignUp : Form
    {
        static HttpClient client = new HttpClient();
        public CredentialsSignUp()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public class ToSend
        {
            public string fullName { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string email { get; set; }
        }

        private void CredentialsSignUp_Load(object sender, EventArgs e)
        {

        }

        private void bt_SignUp_Click_1(object sender, EventArgs e)
        {
            bool isValid = true;

            if (tb_FirstName.Text.Length == 0)
            {
                l_error_firstName.Text = "This field is required!";
                isValid = false;
            }
            else
            {
                l_error_firstName.Text = "";
            }

            if (tb_LastName.Text.Length == 0)
            {
                l_error_lastName.Text = "This field is required!";
                isValid = false;
            }
            else
            {
                l_error_lastName.Text = "";
            }

            if (tb_Username.Text.Length == 0)
            {
                l_error_username.Text = "This field is required!";
                isValid = false;
            }
            else
            {
                l_error_username.Text = "";
            }

            if (tb_Email.Text.Length == 0)
            {
                l_error_email.Text = "This field is required!";
                isValid = false;
            }
            else
            {
                l_error_email.Text = "";
            }

            if (tb_Password.Text.Length == 0)
            {
                l_error_password.Text = "This field is required!";
                isValid = false;
            }
            else
            {
                l_error_password.Text = "";
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");

            if (
                tb_Password.Text.Length < 8 ||
                !hasNumber.IsMatch(tb_Password.Text) ||
                !hasUpperChar.IsMatch(tb_Password.Text))

            {
                l_error_password.Text = "The password must have at least 8 characters, a number and an uppercase letter!";
                isValid = false;
            }
            else
            {
                l_error_password.Text = "";
            }

            if (isValid)
            {
                Token token = new Token();
                this.Hide();
                token.Show();
            }

            var toSend = new ToSend()
            {
                fullName = tb_FirstName.Text.Trim() + " " + tb_LastName.Text.Trim(),
                username = tb_Username.Text.Trim(),
                //password = tb_Password.Text.Trim(), //parola criptata
                password = EncryptPasswords.GenerateHash(tb_Password.Text.Trim(), EncryptPasswords.CreateSalt(5)), //criptare cu salt
                email = tb_Email.Text.Trim()
            };

            client.PostAsJsonAsync("/api/Account/Create", toSend);

        }

        private void cb_Agree_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_Agree.Checked)
            {
                bt_SignUp.Enabled = true;
            }
            else
            {
                bt_SignUp.Enabled = false;
            }
        }

        private void lL_Terms_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("https://privacyterms.io/view/fmAPyNfv-48B6KG3Q-DP6WQR/");
        }

        private void tb_FirstName_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_FirstName.Text.Length == 0)
            {
                l_error_firstName.Text = "This field is required!";
            }
            else
            {
                l_error_firstName.Text = "";
            }
        }

        private void tb_LastName_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_LastName.Text.Length == 0)
            {
                l_error_lastName.Text = "This field is required!";
            }
            else
            {
                l_error_lastName.Text = "";
            }
        }

        private void tb_Username_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_Username.Text.Length == 0)
            {
                l_error_username.Text = "This field is required!";
            }
            else
            {
                l_error_username.Text = "";
            }
        }

        private void tb_Email_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_Email.Text.Length == 0)
            {
                l_error_email.Text = "This field is required!";
            }
            else
            {
                l_error_email.Text = "";
            }
        }

        private void tb_Password_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_Password.Text.Length == 0)
            {
                l_error_password.Text = "This field is required!";
            }
            else
            {
                l_error_password.Text = "";
            }
        }

        private void bt_ShowPassword_Click_1(object sender, EventArgs e)
        {
            if (tb_Password.PasswordChar == '•') tb_Password.PasswordChar = default;
            else tb_Password.PasswordChar = '•';
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            SignUpMenu back = new SignUpMenu();
            this.Hide();
            back.Show();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
