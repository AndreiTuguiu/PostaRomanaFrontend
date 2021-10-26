using System;
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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
            AddEvent1 event1 = new AddEvent1();
            AddEvent2 event2 = new AddEvent2();
            AddEvent3 event3 = new AddEvent3();
            tb_NameOfEvent.Text = event1.tb_EventName.Text;
            cb_EventType.SelectedItem = event3.cb_EventType.SelectedItem;
            tb_EventDesc.Text = event1.tb_Description.Text;
            dt_start.Value = event2.StartDate.Value;
            dt_end.Value = event2.EndDate.Value;
            tb_AddressLine.Text = event2.AddressLine.Text;
            cb_country.SelectedItem = event2.countryBox.SelectedItem;
            cb_county.SelectedItem = event2.countiesBox.SelectedItem;
            cb_city.SelectedItem = event2.citiesBox.SelectedItem;
            tb_Cost.Text = event3.tb_cost.Text;
        }

        private void b_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
