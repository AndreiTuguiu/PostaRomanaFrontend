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
        BindingSource bs;
        public MainPage()
        {
            InitializeComponent();
            countries = new List<string>();
            countries.Add("Romania");
            countries.Add("Italia");
            countries.Add("Grecia");
            counties = new List<(string, string)>();
            counties.Add(("Romania","Prahova"));
            counties.Add(("Romania", "Iasi"));
            counties.Add(("Romania", "Vrancea"));
            counties.Add(("Grecia", "Pieria"));
            cities = new List<(string, string)>();
            cities.Add(("Prahova", "Valenii de Munte"));
            cities.Add(("Iasi", "Iasi"));
            cities.Add(("Pieria", "Katerini"));

            lb_country.DataSource = countries;
            bs = new BindingSource();
            lb_city.DataSource = bs;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = (string)lb_country.SelectedItem;
            if(selectedCountry != null)
            {
                lb_county.Items.Clear();
                List<string> selectedCounties = counties.FindAll(x=> x.Item1 == selectedCountry).Select(x=> x.Item2).ToList();
                lb_county.DataSource = selectedCounties;
            }
        }


        private void lb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCounty = (string)lb_county.SelectedItem;
            if (selectedCounty != null)
            {
                lb_city.Items.Clear();
                List<string> selectedCities = cities.FindAll(x => x.Item1 == selectedCounty).Select(x => x.Item2).ToList();
                bs.DataSource = selectedCities;
            }
        }
    }
}
