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
        public Confirm(string name, string desc, string addline, DateTime start, DateTime end, int country, int county, int city,decimal cost, int type)
        {
            InitializeComponent();
            tb_NameOfEvent.Text = name;
            tb_EventDesc.Text = desc;
            tb_AddressLine.Text = addline;
            cb_EventType.SelectedIndex = type;
            dt_start.Value = start;
            dt_end.Value = end;
            cb_country.SelectedIndex = country;
            cb_county.SelectedIndex = county;
            cb_city.SelectedIndex = city;
            tb_Cost.Text = cost.ToString();
        }

        private void b_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
