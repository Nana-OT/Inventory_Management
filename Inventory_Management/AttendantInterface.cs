using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV;
using DgvFilterPopup;

namespace Inventory_Management
{
    public partial class AttendantInterface : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        DataTable dt;
        public AttendantInterface()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            // {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `prodname`, `Price(GHs)` FROM `product` WHERE 1", connection);
            dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            AttendantProDataGrid.DataSource = dt;
            //  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("prodname LIKE '%{0}%'", searchtextBox.Text);

            AttendantProDataGrid.DataSource = dv;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void AttendantInterface_Load(object sender, EventArgs e)
        {

        }

        private void AttendantProDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AttendantProDataGrid.Rows[e.RowIndex];
                ProductTxtBox.Text = row.Cells["prodname"].Value.ToString();
                PriceTxtBox.Text = row.Cells["Price(Ghs)"].Value.ToString();

            }
        }
        
        


        private void AddBtn_Click(object sender, EventArgs e)
        {
            attendantsDataGrid.Rows.Add(ProductTxtBox.Text, PriceTxtBox.Text, QuantityTxtBox.Text);
            MessageBox.Show(ProductTxtBox.Text.ToString() + "is added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close your session?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Session Closed!");
                this.Hide();
                Role role = new Role();
                role.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Continue your Session! ");
                this.Refresh();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(attendantsDataGrid.Width, attendantsDataGrid.Height);
            attendantsDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, attendantsDataGrid.Width, attendantsDataGrid.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Totalbtn_Click(object sender, EventArgs e)
        {
            int sum = 14210;

            textBox1.Text = sum.ToString();

        }
    }
}
