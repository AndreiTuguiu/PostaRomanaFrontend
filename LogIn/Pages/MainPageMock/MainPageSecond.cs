using LogIn.Actions;
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

namespace LogIn.Pages.MainPageMock
{
    public partial class MainPageSecond : Form
    {
        public MainPageSecond()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new LoginMainPage();

            Location = this.Location;
            StartPosition = FormStartPosition.Manual;

            //frm.FormClosing += delegate { this.Show(); }; //atunci cand inchid main page deschide login
            frm.Show();
            //Thread.Sleep(1000);
            this.Close();
        }
        bool SessionExpired = false;
        DateTime ValidTo = DateTime.Now.AddSeconds(4);
        int Countdown = 4;
        private void timer1_Tick(object sender, EventArgs e)
        { Countdown--;
            label2.Text = Countdown.ToString();



            if (SessionChecker.CheckSessionValidity(ValidTo) && SessionExpired == false)
            {
                SessionExpired = true;
                new LoginMainPage().Show();
                this.Hide();
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
