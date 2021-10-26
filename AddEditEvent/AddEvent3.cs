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
        public AddEvent3()
        {
            InitializeComponent();
        }

        private void NextSlide_Click(object sender, EventArgs e)
        {
            Confirm next = new Confirm();
            this.Hide();
            next.Show();
        }

        private void pb_firstStep_Click(object sender, EventArgs e)
        {
            AddEvent1 back = new AddEvent1();
            this.Hide();
            back.Show();
        }

        private void pb_secondStep_Click(object sender, EventArgs e)
        {
            AddEvent2 event2 = new AddEvent2();
            this.Hide();
            event2.Show();
        }
    }
}
