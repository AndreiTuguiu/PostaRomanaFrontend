using LogIn.Actions;
using LogIn.Pages.MainPageMock;
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

namespace PostaRomana.MainPage
{
    public partial class MainPageCode : Form
    {
        public MainPageCode()
        {
            InitializeComponent();
        }
        DateTime ValidTo = DateTime.Now.AddSeconds(4);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        bool SessionExpired = false;

        private void timer1_Tick(object sender, EventArgs e)
        {  
            if(SessionChecker.CheckSessionValidity(ValidTo) && SessionExpired == false)
            {
                SessionExpired = true;
                new LoginMainPage().Show();
                this.Hide();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new MainPageSecond();

            Location = this.Location;
            StartPosition = FormStartPosition.Manual;

            //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
            frm.Show();
            //Thread.Sleep(1000);
            this.Close();
        }
    }
}
