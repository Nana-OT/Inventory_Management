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
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `prodname`,`barcode`, `Quantity`, `Price(GHs)` FROM `product` WHERE 1", connection);
            dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            AttendantProDataGrid.DataSource = dt;
            //  }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            int stock = 0;
            int result = 0;

            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT  `Quantity` FROM `product` WHERE 1", connection);            

            MySqlDataReader read = command.ExecuteReader();
            while(read.Read())
            {
                string quantity = (read["Quantity"]).ToString();
                stock = int.Parse(quantity);
            }
            int add = Convert.ToInt32(QuantityTxtBox.Text);

            result = add - stock;
            connection.Close();

            connection.Open();
            MySqlCommand Command = new MySqlCommand("UPDATE `product` SET `Quantity`='"+result+"' WHERE 1", connection);
            Command.ExecuteNonQuery();

            ProductTxtBox.Text = String.Empty;
            PriceTxtBox.Text = String.Empty;
            QuantityTxtBox.Text = String.Empty;

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `product` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            AttendantProDataGrid.DataSource = dt;
            connection.Close();

        }
    }
}
