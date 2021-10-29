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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        
        private Image _icon;
        private string _name;
        private string _organizerName;
        private string _date;
        private string _location;
        private decimal _cost ;

       [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value;  pb_Icon.Image = value; }
        }

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; l_name.Text = value; }
        }

        [Category("Custom Props")]
        public string OrganizerName
        {
            get { return _organizerName; }
            set { _organizerName = value; l_organizer.Text = value; }
        }


        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; l_date.Text = value; }
        }

        [Category("Custom Props")]
        public string Location
        {
            get { return _location; }
            set { _location = value; l_location.Text = value; }
        }

        //[Category("Custom Props")]
        //decimal c = Decimal.Parse(l_cost.Text);
        //public decimal Cost
        //{
            
        //    get { return _cost; }
        //    set { _cost = value; c = value; }
        //}

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
