using Models;
using Newtonsoft.Json;
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

namespace AddEditEvent
{
    public partial class Confirm : Form
    {
        static HttpClient client = new HttpClient();

        public string EvName { get; set; }
        public string Description { get; set; }
        public int EventyType { get; set; }
        public string Addressline { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CountryId { get; set; }
        public int CountyId { get; set; }
        public int CityId { get; set; }
        public decimal Cost { get; set; }
        public Confirm(string name, string desc, string addline, DateTime start, DateTime end, int country, int county, int city,decimal cost, int type)
        {

            InitializeComponent();


            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

            EvName = name;
            Description = desc;
            EventyType = type;
            Addressline = addline;
            StartDate = start;
            EndDate = end;
            CountryId = country;
            CountyId = county;
            CityId = city;
            Cost = cost;

            tb_NameOfEvent.Text = EvName;
            tb_EventDesc.Text = Description;
            tb_AddressLine.Text = Addressline;
            cb_EventType.SelectedIndex = EventyType;
            dt_start.Value = StartDate;
            dt_end.Value = EndDate;
            tb_Cost.Text = Cost.ToString();
            
        }
        List<Country> countries;
        List<County> counties;
        List<City> cities;
        public class toSend
        {
            public string name { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public int countryId { get; set; }
            public int countyId { get; set; }
            public int cityId { get; set; }
            public string addressLine { get; set; }
            public decimal cost { get; set; }
            public int eventTypeId { get; set; }
            public int organizerId { get; set; }
            public string description { get;set; }
        }

        private void b_Confirm_Click(object sender, EventArgs e)
        {
            MainPage.MainPage main = new MainPage.MainPage();
            main.Show();

            var CountryId = getCountryId();
            var CountyId = getCountyId();
            var CityId = getCityId();
            var Address = tb_AddressLine.Text;
            var EventName = tb_NameOfEvent.Text;
            var organizer = 1;
            var Start = dt_start.Value;
            var End = dt_end.Value;
            var Type = 1;
            var CostOfEvent = Cost;
            toSend send = new toSend()
            {
                name= EventName,
                startDate= Start,
                endDate= End,
                countryId= CountryId,
                countyId= CountyId,
                cityId= CityId,
                addressLine= Address,
                organizerId= organizer,
                eventTypeId= Type,
                cost= CostOfEvent,
                description=tb_EventDesc.Text
            };
            

            client.PostAsJsonAsync("/api/Event/EventCommands", send);
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            cb_country.DataSource = LoadCountries();
            var c = LoadCountiesByCountry(CountryId);
            cb_county.DataSource = c;
            for(int i = 0; i < c.Count ; i++)
            {
                if (c[i].Id == CountyId)
                {
                    cb_county.Text = c[i].Name;
                    break;
                }
            }
            
            List<City> l = LoadCitiesByCounty(CountyId);
            cb_city.DataSource = l;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].Id == CountyId)
                {
                    cb_county.Text = l[i].Name;
                    break;
                }
            }
            
            cb_country.SelectedIndex = CountryId;
            
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region attempt1
        //private async void LoadCountry()
        //{
        //    List<Country> _country = new List<Country>();
        //    HttpResponseMessage response = await client.GetAsync("api/Event/ListOfCountries");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        _country.AddRange(await response.Content.ReadAsAsync<List<Country>>());


        //    }
        //    cb_country.DataSource = _country;
        //    cb_country.SelectedIndex = CountryId;
        //    LoadCounty(CountryId);
        //    //cb_country.SelectedIndex = -1;
        //}
        //private async void LoadCounty(int countryId)
        //{
        //    CountryId = 0;
        //    List<County> _county = new List<County>();

        //    HttpResponseMessage response = await client.GetAsync($"api/Event/ListOfCounties?CountryId={countryId}");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        _county.AddRange(await response.Content.ReadAsAsync<List<County>>());


        //    }
        //    cb_county.DataSource = _county;
        //    cb_county.SelectedIndex = CountyId;
        //    //cb_county.SelectedIndex = -1;
        //    LoadCity(CountyId);

        //}

        //private async void LoadCity(int countyId)
        //{
        //    CountyId = 0;
        //    List<City> _city = new List<City>();


        //    HttpResponseMessage response = await client.GetAsync($"api/Event/ListOfCities?CountyId={countyId}");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        _city.AddRange(await response.Content.ReadAsAsync<List<City>>());


        //    }
        //    cb_city.DataSource = _city;
        //    cb_city.SelectedIndex = CityId;
        //    //cb_city.SelectedIndex = -1;



        //}
        #endregion

        private List<string> LoadCountries()
        {
            var url = "https://localhost:5001/api/Event/ListOfCountries";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<Country> list = new List<Country>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Country>>(result);
            }
            countries = list;
            List<string> _countries = new List<string>();

            foreach(var items in list)
            {
                _countries.Add(items.Name);
            }
            return _countries;
        }

        private List<string> LoadCounties()
        {
            var url = $"https://localhost:5001/api/Event/GetfCounties";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<County> list = new List<County>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<County>>(result);
            }
            counties = list;
            List<string> _counties = new List<string>();


            list.ForEach(item => _counties.Add(item.Name));
            

            return _counties;
        }

        private List<string> LoadCities()
        {
            var url = $"https://localhost:5001/api/Event/GetfCities";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<City> list = new List<City>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<City>>(result);
            }
            cities = list;
            List<string> _cities = new List<string>();

            foreach (var items in list)
            {
                _cities.Add(items.Name);
            }
            return _cities;
        }
        private List<County> LoadCountiesByCountry(int country)
        {
            var url = $"https://localhost:5001/api/Event/ListOfCounties?CountryId={country}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<County> list = new List<County>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<County>>(result);
            }
            counties = list;
            //List<string> _counties = new List<string>();

            //foreach (var items in list)
            //{
            //    _counties.Add(items.Name);
            //}
            return counties;
        }
        private List<City> LoadCitiesByCounty(int county)
        {
            var url = $"https://localhost:5001/api/Event/ListOfCities?CountyId={county}";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            List<City> list = new List<City>();
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<City>>(result);
            }
            cities = list;
            //List<string> _counties = new List<string>();

            //foreach (var items in list)
            //{
            //    _counties.Add(items.Name);
            //}
            return cities;
        }


        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_county.SelectedIndex = -1;

            string selectedCountry = (string)cb_country.SelectedItem;
            var selection = countries.FirstOrDefault(x => x.Name == selectedCountry);
            if( selection == null)
            {
                return;
            }

            var countryId = selection.Id;
            cb_county.DataSource = LoadCountiesByCountry(countryId);
        }

        private void cb_county_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_city.SelectedIndex = -1;

            string selectedCounty = (string)cb_county.SelectedText;
            var selection = counties.FirstOrDefault(x => x.Name == selectedCounty);
            if (selection == null)
            {
                return;
            }

            var countyId = selection.Id;
            cb_city.DataSource = LoadCitiesByCounty(countyId);
        }

        public int getCountryId()
        {
            string selectedCountryName = (string)cb_country.SelectedText;
            if(countries != null)
            {
                var selectedCountry = countries.FirstOrDefault(x => x.Name == selectedCountryName);
                var countryId = selectedCountry.Id;
                return countryId;
            }
            return -1;
        }

        public int getCountyId()
        {
            string selectedCountyName = (string)cb_county.SelectedItem;
            if (counties != null)
            {
                var selectedCounty = counties.FirstOrDefault(x => x.Name == selectedCountyName);
                var countyId = selectedCounty.Id;
                return countyId;
            }
            return -1;
        }

        public int getCityId()
        {
            string selectedCityName = (string)cb_city.SelectedItem;
            if (cities != null)
            {
                var selectedCity = cities.FirstOrDefault(x => x.Name == selectedCityName);
                var cityId = selectedCity.Id;
                return cityId;
            }
            return -1;
        }
    }
}
