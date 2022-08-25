using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class AttendantWelcome : Form
    {
        public AttendantWelcome()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to start a new session?", "Confirm!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Session Started!");
                this.Hide();
                AttendantInterface attendantInterface = new AttendantInterface();
                attendantInterface.Show();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Session not started! ");
                this.Refresh();
            }
        }

        private void AttendantForm1_Load(object sender, EventArgs e)
        {

        }

        private void attendantbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role role = new Role();
            role.Show();
        }
    }
}
