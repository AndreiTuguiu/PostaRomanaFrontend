using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!Regex.IsMatch(recoverPasswordTextBox.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            { label_recover_invalidEmail.Visible = true;
            label_passwordRecoverySuccess.Visible = false; }
            else
            { label_passwordRecoverySuccess.Visible = true;
                label_recover_invalidEmail.Visible = false; }

        }

       

        private void recoverPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_recover_sendCode_Click(sender, e);
            }
        }

        private void recoverPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
