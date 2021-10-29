using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    public partial class MainPage : Form
    {
        List<string> countries;
        List<(string, string)> counties;
        List<(string, string)> cities;
        List<string> intervals;
        List<string> eventTypes;
        List<string> locations;
        List<string> organizers;
        List<string> costs;

        BindingSource bs;
        public MainPage()
        {
            InitializeComponent();
            locations = new List<string>();
            locations.Add("Greacia, Pieria, Katerini");
            locations.Add("Romania, Iasi, Iasi");

            //asta ramane
            cb_Interval.DataSource = intervals;
            cb_Interval.ResetText();
            cb_Location.SelectedIndex = -1;
            cb_EventType.DataSource = eventTypes;
            cb_EventType.ResetText();
            cb_EventType.SelectedIndex = -1;
            cb_Location.DataSource = locations;
            cb_Location.ResetText();
            cb_Location.SelectedIndex = -1;
            cb_Organizer.DataSource = organizers;
            cb_Organizer.ResetText();
            cb_Organizer.SelectedIndex = -1;
            cb_Cost.DataSource = costs;
            cb_Cost.ResetText();
            cb_Cost.SelectedIndex = -1;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void l_login_Click(object sender, EventArgs e)
        {
            //LoginMainPage login = new LoginMainPage();
            //login.Show();
        }

        private void pb_Search_Click(object sender, EventArgs e)
        {

        }

        private void cb_Location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Interval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
