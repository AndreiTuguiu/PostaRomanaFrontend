using LogIn.Actions;
using MainPage;
using PostaRomana.AddEditEvent;
using PostaRomana.LogIn;
using PostaRomanaFrontend.Properties;
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
            GenerateDynamicUserControl();
            hidePanel();
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
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ListItem[] listItems = new ListItem[5];

            string[] name = new string[5] { "Concert Vita de Vie", "Simfonia celor 3", "Electric Castle", "Untold", "Neversea" };
            string[] organizerName = new string[5] { "Hard Rock Cafe", "Casa de Cultura din Galati", "nmnsn", "org1", "org2" };
            string[] date = new string[5] { "12.03.2021", "04.06.2022", "16.02.2023", "16.02.2024", "16.02.2025" };
            string[] location = new string[5] { "Bucuresti", "Galati", "Cluj", "Brasov", "Iasi" };
            string[] cost = new string[5] { "10", "0", "700", "1000", "123" };
            Image[] icons = new Image[5] {
                Resources.OIP,
                Resources.showpasgrey,
                Resources.OIP,
                Resources.showpasgrey,
                Resources.OIP
            };

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();

                listItems[i].Icon = icons[i];
                listItems[i].Name = name[i];
                listItems[i].OrganizerName = organizerName[i];
                listItems[i].Date = date[i];
                listItems[i].Location = location[i];
                listItems[i].Cost = cost[i];

                flowLayoutPanel1.Controls.Add(listItems[i]);
                listItems[i].Click += new System.EventHandler(this.UserControl_Click);
            }
        }

        void UserControl_Click(object sender, EventArgs e)
        {
            ListItem obj = (ListItem)sender;
            l_Title.Text = obj.Name;
            l_Description.Text = obj.Description;
            l_Type.Text = obj.Type;
            l_StartDate.Text = obj.Date;
            l_EndDate.Text = obj.DateEnd;
            l_AddressLine.Text = obj.Location;
            l_Country.Text = obj.Country;
            l_County.Text = obj.County;
            l_City.Text = obj.City;
            l_Cost.Text = obj.Cost;

            showPanel();
        }

        private void showPanel()
        {
            panel6.Visible = true;
        }

        private void hidePanel()
        {
            panel6.Visible = false;
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void l_login_Click(object sender, EventArgs e)
        {
            LoginMainPage login = new LoginMainPage();
            login.Show();
        }

        private void bt_AddEvent_Click(object sender, EventArgs e)
        {
            AddEvent1 add = new AddEvent1();
            add.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            hidePanel();
        }
        bool SessionExpired = false;
        DateTime ValidTo = DateTime.Now.AddMinutes(10); // aici modifici cat sa dureze sesiunea

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (SessionChecker.CheckSessionValidity(ValidTo) && SessionExpired == false)
            {
                SessionExpired = true;
                new LoginMainPage().Show();
                timer1.Enabled = false;  //daca stergi asta atunci ramane 10 minute per total, fara reset la schimbarea paginii
                this.Hide();
            };
        }
    }
}
