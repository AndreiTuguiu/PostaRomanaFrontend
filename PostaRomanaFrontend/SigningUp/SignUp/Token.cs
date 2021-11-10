using System;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace PostaRomanaFrontend.SignUp
{
    public partial class Token : Form
    {
        static HttpClient client = new HttpClient();
        public Token()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public class ToSend
        {
            public string token { get; set; }
        }

        private void bt_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Register_Click(object sender, System.EventArgs e)
        {
            PostaRomana.MainPage.MainPage main = new PostaRomana.MainPage.MainPage();
            this.Hide();
            main.Show();

            var toSend = new ToSend()
            {
                token = tb_Token.Text.Trim()
            };

            client.PostAsJsonAsync("/api/Account/Token", toSend);
        }

        private void tb_Token_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
