﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddEditEvent
{
    public partial class AddEvent2 : Form
    {
        public AddEvent2()
        {
            InitializeComponent();
        }

        private void AddEvent2_Load(object sender, EventArgs e)
        {


        }

        private void NextSlide_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MyStartDate = StartDate.Value;
            Properties.Settings.Default.MyEndDate = EndDate.Value;
            Properties.Settings.Default.MyAddressLine = AddressLine.Text;
            Properties.Settings.Default.MyCountry = countryBox.SelectedIndex;
            Properties.Settings.Default.MyCity = citiesBox.SelectedIndex;
            Properties.Settings.Default.MyCounty = countiesBox.SelectedIndex;
            AddEvent3 next = new AddEvent3();
            this.Hide();
            next.Show();
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
    }
}
