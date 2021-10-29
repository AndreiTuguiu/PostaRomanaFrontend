using System.Drawing;
using System.Windows.Forms;

namespace PostaRomanaFrontend.SignUp
{
    public partial class Token : Form
    {
        public Token()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Register_Click(object sender, System.EventArgs e)
        {
            MainPage.MainPage main = new MainPage.MainPage();
            main.Show();
        }

        private void tb_Token_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
