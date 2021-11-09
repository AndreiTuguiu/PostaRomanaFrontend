using LogIn.Actions;
using MainPage;
using Models;
using Newtonsoft.Json;
using PostaRomana.AddEditEvent;
using PostaRomana.LogIn;
using PostaRomanaFrontend.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostaRomana.MainPage
{
    public partial class MainPage : Form
    {
        List<Country> countries;
        List<County> counties;
        List<City> cities;
        List<string> intervals;
        List<string> eventTypes;
        List<string> locations;
        List<string> organizers;
        List<string> costs;
        List<Event> events;

        static HttpClient client = new HttpClient();
        

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


            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            events = LoadEvents();

            ListItem[] listItems = new ListItem[events.Count()];

            int[] Locids = LoadEventLocIDs().ToArray();
            string[] name = LoadEventNames().ToArray();
            int[] organizerName = LoadEventOrganizer().ToArray();
            DateTime[] date = LoadEventStartDate().ToArray();
            int[] location = LoadEventLocation().ToArray();
            decimal?[] cost = LoadEventCost().ToArray();
            Image[] icons = new Image[5] {
                Resources.OIP,
                Resources.showpasgrey,
                Resources.OIP,
                Resources.showpasgrey,
                Resources.OIP
            };
            int i;
            for ( i = 0; i < events.Count(); i++)
            {
                listItems[i] = new ListItem();
                if (listItems[i].Icon != null)
                {
                    listItems[i].Icon = icons[i];
                }
                listItems[i].LocId = Locids[i];
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
            l_Type.Text = obj.Type.ToString();
            l_StartDate.Text = obj.Date.ToString();
            l_EndDate.Text = obj.DateEnd.ToString();
            l_AddressLine.Text = obj.Location.ToString();
            l_Country.Text = LoadCountryName(obj.LocId);
            l_County.Text = LoadCountyName(obj.LocId);
            l_City.Text = LoadCityName(obj.LocId);
            l_Cost.Text = obj.Cost.ToString();

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

        private List<int> LoadEventLocIDs()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<int> _eventIDs = new List<int>();

            foreach (var item in list)
            {
                _eventIDs.Add(item.LocationId);
            }
            return _eventIDs;
        }

        private List<string> LoadEventNames()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<string> _eventNames = new List<string>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Name);
            }
            return _eventNames;
        }
        private List<Event> LoadEvents()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<Event> _events = new List<Event>();

            foreach (var item in list)
            {
                _events.Add(item);
            }
            return _events;
        }

        private List<int> LoadEventOrganizer()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<int> _eventOrg = new List<int>();

            foreach (var item in list)
            {
                _eventOrg.Add(item.OrganizerId);
            }
            return _eventOrg;
        }

        private List<DateTime> LoadEventStartDate()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<DateTime> _eventSD = new List<DateTime>();

            foreach (var item in list)
            {
                _eventSD.Add(item.StartDate);
            }
            return _eventSD;
        }

        private List<Decimal?> LoadEventCost()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<Decimal?> _eventCost = new List<Decimal?>();

            foreach (var item in list)
            {
                _eventCost.Add(item.Cost);
            }
            return _eventCost;
        }

        private List<int> LoadEventLocation()
        {
            var url = "https://localhost:5001/api/Event/ListOfEvents";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Event> list = new List<Event>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Event>>(result);
            }
            events = list;
            List<int> _eventLocation = new List<int>();

            foreach (var item in list)
            {
                _eventLocation.Add(item.LocationId);
            }
            return _eventLocation;
        }

        private string LoadCountryName(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetCountryById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Country> list = new List<Country>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Country>>(result);
            }
            countries = list;
            List<string> _eventNames = new List<string>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Name);
            }
            return _eventNames[0];
        }

        private string LoadCountyName(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetCountyById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<County> list = new List<County>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<County>>(result);
            }
            counties = list;
            List<string> _eventNames = new List<string>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Name);
            }
            return _eventNames[0];
        }

        private string LoadCityName(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetCityById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<City> list = new List<City>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<City>>(result);
            }
            cities = list;
            List<string> _eventNames = new List<string>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Name);
            }
            return _eventNames[0];
        }
    }
}
