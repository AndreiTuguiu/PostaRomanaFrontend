﻿using AddEditEvent;
using Models;
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


namespace PostaRomana.AddEditEvent
{
    public partial class AddEvent2 : Form
    {
        static HttpClient client = new HttpClient();

        string NameEv { get; set; }
        string Descr { get; set; }
        public AddEvent2(string name, string desc)
        {
            InitializeComponent();
            NameEv = name;
            Descr = desc;
            
            // countryBox.DataSource = listOfCountries;
            // countryBox.DisplayMember = "Name";
            // countryBox.ValueMember = "Id";
            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            LoadCountry();
        }

        private void AddEvent2_Load(object sender, EventArgs e)
        {


        }

        private void NextSlide_Click(object sender, EventArgs e)
        {

            int country = countryBox.SelectedIndex;
            int county = countiesBox.SelectedIndex;
            int city = citiesBox.SelectedIndex;

            if (AddressLine.Text.Length > 0 && countryBox.Text.Length > 0 && countiesBox.Text.Length > 0 && citiesBox.Text.Length > 0)
            {
                l_Error.Visible = false;
                //Properties.Settings.Default.MyStartDate = StartDate.Value;
                //Properties.Settings.Default.MyEndDate = EndDate.Value;
                //Properties.Settings.Default.MyAddressLine = AddressLine.Text;
                //Properties.Settings.Default.MyCountry = countryBox.SelectedIndex;
                //Properties.Settings.Default.MyCity = citiesBox.SelectedIndex;
                //Properties.Settings.Default.MyCounty = countiesBox.SelectedIndex;
                AddEvent3 next = new AddEvent3(NameEv, Descr, AddressLine.Text, StartDate.Value, EndDate.Value, country, county, city);
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

        private void pb_firstStep_Click(object sender, EventArgs e)
        {
            AddEvent1 back = new AddEvent1();
            this.Hide();
            back.Show();
        }

        private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            var selectedCountry = (Country)cmb.SelectedItem;
            if(selectedCountry!= null)
            {
                LoadCounty(selectedCountry.Id);
            }
        }
            
        private async void LoadCountry()
            {
                List<Country> _country = new List<Country>();
                
                HttpResponseMessage response = await client.GetAsync("api/Event/ListOfCountries");
                if (response.IsSuccessStatusCode)
                {
                    _country.AddRange(await response.Content.ReadAsAsync<List<Country>>());
                    countryBox.DataSource = _country;
                    
                }

            countryBox.SelectedIndex = -1;

        }

        private async void LoadCounty(int countryId)
        {
            List<County> _county = new List<County>();
            
            
            HttpResponseMessage response = await client.GetAsync($"api/Event/ListOfCounties?CountryId={countryId}");
            if (response.IsSuccessStatusCode)
            {
                _county.AddRange(await response.Content.ReadAsAsync<List<County>>());
                countiesBox.DataSource = _county;
                
            }
            countiesBox.SelectedIndex = -1;


        }

        private async void LoadCity(int countyId)
        {
            List<City> _city = new List<City>();
           
           

            HttpResponseMessage response = await client.GetAsync($"api/Event/ListOfCities?CountyId={countyId}");
            if (response.IsSuccessStatusCode)
            {
                _city.AddRange(await response.Content.ReadAsAsync<List<City>>());
                citiesBox.DataSource = _city;
               
            }
            citiesBox.SelectedIndex = -1;



        }

        private void countiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            var selectedCounty = (County)cmb.SelectedItem;
            if (selectedCounty != null)
            {
                LoadCity(selectedCounty.Id);
            }
        }
    }
}
