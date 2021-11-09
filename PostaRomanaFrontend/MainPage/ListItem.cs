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
        private int _locid;
        private string _name;
        private int _organizerName;
        private int _type;
        private string _description;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private int _addressLine;
        private string _country;
        private string _county;
        private string _city;
        private decimal? _cost;


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
        public int OrganizerName
        {
            get { return _organizerName; }
            set { _organizerName = value; l_organizer.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public DateTime Date
        {
            get { return _dateStart; }
            set { _dateStart = value; l_date.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int Location
        {
            get { return _addressLine; }
            set { _addressLine = value; l_location.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        //decimal c = decimal.Parse(l_cost.Text);
        public decimal? Cost
        {
            get { return _cost; }
            set { _cost = value; l_cost.Text = value.ToString(); }
        }

        public int LocId { get => _locid; set => _locid = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime DateEnd { get => _dateEnd; set => _dateEnd = value; }
        public string Country { get => _country; set => _country = value; }
        public string County { get => _county; set => _county = value; }
        public string City { get => _city; set => _city = value; }
        public int Type { get => _type; set => _type = value; }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
