using AddEditEvent;
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
        List<Location> locations;
        List<string> intervals;
        List<string> eventTypes;
        List<string> organizers;
        List<string> costs;
        List<Event> events;

        static HttpClient client = new HttpClient();

        private ListItem obj;
        public ListItem theEvent { get => obj; set => obj = value; }

        BindingSource bs;
        public MainPage()
        {
            InitializeComponent();
            GenerateDynamicUserControl();
            hidePanel();
            

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


            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            events = LoadEvents();

            ListItem[] listItems = new ListItem[events.Count()];

            int[] types = LoadEventType().ToArray();
            int[] Locids = LoadEventLocIDs().ToArray();
            string[] name = LoadEventNames().ToArray();
            string[] desc = LoadEventDesc().ToArray();
            int[] organizerName = LoadEventOrganizer().ToArray();
            DateTime[] startdate = LoadEventStartDate().ToArray();
            DateTime[] enddate = LoadEventEndDate().ToArray();
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
                listItems[i].Type = types[i];
                listItems[i].Name = name[i];
                listItems[i].Description = desc[i];
                listItems[i].OrganizerName = organizerName[i];
                listItems[i].Date = startdate[i];
                listItems[i].DateEnd = enddate[i];
                listItems[i].Location = location[i];
                listItems[i].Cost = cost[i];

                flowLayoutPanel1.Controls.Add(listItems[i]);
                listItems[i].Click += new System.EventHandler(this.UserControl_Click);
            }
        }

        void UserControl_Click(object sender, EventArgs e)
        {
            obj = (ListItem)sender;
            l_Title.Text = obj.Name;
            l_Description.Text = obj.Description;
            l_Type.Text = obj.Type.ToString();
            l_StartDate.Text = obj.Date.ToString();
            l_EndDate.Text = obj.DateEnd.ToString();
            l_AddressLine.Text = LoadEventLocAddress(obj.LocId);
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
        private string LoadEventLocAddress(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetAddressById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Location> list = new List<Location>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Location>>(result);
            }
            locations = list;
            List<string> _eventadd = new List<string>();

            foreach (var item in list)
            {
                _eventadd.Add(item.AddressLine);
            }
            return _eventadd[0];
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
        private List<string> LoadEventDesc()
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
                _eventNames.Add(item.Description);
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

        private List<DateTime> LoadEventEndDate()
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
            List<DateTime> _eventED = new List<DateTime>();

            foreach (var item in list)
            {
                _eventED.Add(item.EndDate);
            }
            return _eventED;
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

        private List<int> LoadEventType()
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
                _eventLocation.Add(item.EventTypeId);
            }
            return _eventLocation;
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
        private int LoadCountryId(int LocationId)
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
            List<int> _eventNames = new List<int>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Id);
            }
            return _eventNames[0];
        }
        private int LoadCountyId(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetCountryById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<County> list = new List<County>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<County>>(result);
            }
            counties = list;
            List<int> _eventNames = new List<int>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Id);
            }
            return _eventNames[0];
        }

        private int LoadCityId(int LocationId)
        {
            var url = $"https://localhost:5001/api/Event/GetCountryById/{LocationId}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<City> list = new List<City>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<City>>(result);
            }
            cities = list;
            List<int> _eventNames = new List<int>();

            foreach (var item in list)
            {
                _eventNames.Add(item.Id);
            }
            return _eventNames[0];
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            string nameofevent = theEvent.Name;
            string desc = theEvent.Description;
            string add = LoadEventLocAddress(theEvent.LocId);
            DateTime start = theEvent.Date;
            DateTime end = theEvent.DateEnd;
            int country = LoadCountryId(theEvent.LocId);
            int county = LoadCountyId(theEvent.LocId);
            int city = LoadCityId(theEvent.LocId);
            decimal? cost = theEvent.Cost;
            int type = theEvent.Type;

            Confirm edit = new Confirm(nameofevent, desc,add,start,end,country,county,city,cost,type);
            this.Hide();
            edit.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();

        }
    }
}
