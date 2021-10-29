using PostaRomana.LogIn;
using System;
using System.Windows.Forms;

namespace PostaRomanaFrontend.SignUp
{
    public partial class SignUpMenu : Form
    {
        public SignUpMenu()
        {
            InitializeComponent();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            CredentialsSignUp csu = new CredentialsSignUp();
            csu.Show();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMainPage log = new LoginMainPage();
            log.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
