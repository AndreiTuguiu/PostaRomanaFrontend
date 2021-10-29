using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostaRomana.AddEditEvent
{
    public partial class AddEvent1 : Form
    {
        public AddEvent1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tb_EventName.Text = Properties.Settings.Default.MyEventName;
            //tb_Description.Text = Properties.Settings.Default.MyDescription;
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextSlide_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.MyEventName = tb_EventName.Text;
            //Properties.Settings.Default.MyDescription = tb_Description.Text;
            //Properties.Settings.Default.Save();

            
            AddEvent2 next = new AddEvent2(tb_EventName.Text,tb_Description.Text);
            this.Hide();
            next.Show();
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string MyEventName
        {
            get { return tb_EventName.Text; }
        }

        public string MyDescription
        {
            get { return tb_Description.Text; }
        }

        private void bt_NextSlide_Click(object sender, EventArgs e)
        {
           

            //Properties.Settings.Default.MyEventName = tb_EventName.Text;
            //Properties.Settings.Default.MyDescription = tb_Description.Text;
            //Properties.Settings.Default.Save();


            if (tb_EventName.Text.Length > 0 && tb_Description.Text.Length > 0)
            {
                l_Error.Visible = false;
                AddEvent2 next = new AddEvent2(tb_EventName.Text, tb_Description.Text);
                this.Hide();
                next.Show();
            }
            else
            {
                l_Error.Visible = true;
            }
            
        }
    }
}
