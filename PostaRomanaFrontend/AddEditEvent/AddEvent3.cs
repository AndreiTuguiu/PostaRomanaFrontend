using LogIn.Actions;
using PostaRomana.AddEditEvent;
using PostaRomana.LogIn;
using PostaRomanaFrontend.AddEditEvent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddEditEvent
{
    public partial class AddEvent3 : Form
    {
        static HttpClient client = new HttpClient();
        string NameEv { get; set; }
        string Descr { get; set; }
        string ALine { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; }
        int Country { get; set; }
        int County { get; set; }
        int City { get; set; }
        public AddEvent3(string name, string desc, string addline, DateTime start, DateTime end, int country, int county, int city)
        {
            InitializeComponent();
            NameEv = name;
            Descr = desc;
            ALine = addline;
            Start = start;
            End = end;
            Country = country;
            County = county;
            City = city;
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            LoadTypes();
        }

        private void NextSlide_Click(object sender, EventArgs e)
        {

            decimal deccost = Decimal.Parse(tb_cost.Text);
            Confirm next = new Confirm(NameEv, Descr, ALine, Start, End, Country, County, City, deccost, cb_EventType.SelectedIndex);
            this.Hide();
            next.Show();
        }

        private void pb_firstStep_Click(object sender, EventArgs e)
        {
            AddEvent1 back = new AddEvent1();
            this.Hide();
            back.Show();
        }

        private void AddEvent3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postaRomanaDataSet.EventTypeDictionary' table. You can move, or remove it, as needed.

        }

        private void bt_NextSlide_Click(object sender, EventArgs e)
        {
            if (tb_cost.Text.Length > 0 && cb_EventType.Text.Length > 0)
            {
                decimal deccost = Decimal.Parse(tb_cost.Text);
                Confirm next = new Confirm(NameEv, Descr, ALine, Start, End, Country, County, City, deccost, cb_EventType.SelectedIndex);
                this.Hide();
                next.Show();
            }
            else
            {
                l_Error.Visible = true;
            }
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            AddEvent1 close = new AddEvent1();
            close.Close();
            this.Close();
        }

        private void cb_EventType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void LoadTypes()
        {
            List<EventTypeDictionary> _country = new List<EventTypeDictionary>();

            HttpResponseMessage response = await client.GetAsync("api/Event/GetfTypes");
            if (response.IsSuccessStatusCode)
            {
                _country.AddRange(await response.Content.ReadAsAsync<List<EventTypeDictionary>>());
                cb_EventType.DataSource = _country;

            }

            cb_EventType.SelectedIndex = -1;

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

        //private void pb_secondStep_Click(object sender, EventArgs e)
        //{
        //    AddEvent2 event2 = new AddEvent2();
        //    this.Hide();
        //    event2.Show();
        //}
    }
}
