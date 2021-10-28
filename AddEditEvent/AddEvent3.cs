using PostaRomana.AddEditEvent;
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
    public partial class AddEvent3 : Form
    {
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
        }

        private void NextSlide_Click(object sender, EventArgs e)
        {

            decimal deccost = Decimal.Parse(tb_cost.Text);
            Confirm next = new Confirm(NameEv,Descr,ALine,Start,End,Country,County,City,deccost,cb_EventType.SelectedIndex);
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

        //private void pb_secondStep_Click(object sender, EventArgs e)
        //{
        //    AddEvent2 event2 = new AddEvent2();
        //    this.Hide();
        //    event2.Show();
        //}
    }
}
