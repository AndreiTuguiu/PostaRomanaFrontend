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
        private string _type;
        private string _description;
        private string _dateStart;
        private string _dateEnd;
        private string _addressLine;
        private string _country;
        private string _county;
        private string _city;
        private string _cost;


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_Icon.Image = value; }
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
            get { return _dateStart; }
            set { _dateStart = value; l_date.Text = value; }
        }

        [Category("Custom Props")]
        public string Location
        {
            get { return _addressLine; }
            set { _addressLine = value; l_location.Text = value; }
        }

        [Category("Custom Props")]
        //decimal c = decimal.Parse(l_cost.Text);
        public string Cost
        {
            get { return _cost; }
            set { _cost = value; l_cost.Text = value; }
        }

        public string Description { get => _description; set => _description = value; }
        public string DateEnd { get => _dateEnd; set => _dateEnd = value; }
        public string Country { get => _country; set => _country = value; }
        public string County { get => _county; set => _county = value; }
        public string City { get => _city; set => _city = value; }
        public string Type { get => _type; set => _type = value; }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
