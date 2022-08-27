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
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `id`, `prodname`, `barcode`, `Quantity`, `Price(GHs)` FROM `product` WHERE 1", connection);
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

                IDTextBox.Text = row.Cells["id"].Value.ToString();
                ProductTxtBox.Text = row.Cells["prodname"].Value.ToString();
                PriceTxtBox.Text = row.Cells["Price(Ghs)"].Value.ToString();

            }
        }
        public decimal GetQuantity(int ProdID)
        {
            decimal quantity = 0;

            dt = new DataTable();
            try
            {
                string sql = "SELECT `Quantity`FROM `product` WHERE id =" +ProdID;
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                connection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    quantity = decimal.Parse(dt.Rows[0]["Quantity"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return quantity;
        }
        public bool upDateQuantity(int ProdID, decimal qty)
        {
            bool success = false;

            try
            {
                string sql = "UPDATE `Quantity`FROM `product` WHERE id =" + ProdID.;
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@Quantity", qty);
                cmd.Parameters.AddWithValue("@id", ProdID);

                connection.Open();

                 int rows = cmd.ExecuteNonQuery();
                if(rows > 10)

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `id`, `prodname`, `barcode`, `Quantity`, `Price(GHs)` FROM `product` WHERE 1", connection);
            dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            AttendantProDataGrid.DataSource = dt;
            connection.Close();
            /*connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT  `Quantity` FROM `product` WHERE 'id' = '"+IDTextBox.Text+"'", connection);            

            MySqlDataReader read = command.ExecuteReader();
            while(read.Read())
            {
                int result;
                string quantity = (read["Quantity"]).ToString();
                int stock = int.Parse(quantity);
                int add = Convert.ToInt32(QuantityTxtBox.Text);
                result = stock - add;

                command = new MySqlCommand("UPDATE `product` SET `Quantity`='" + result + "' WHERE `product`.`id` = '"+IDTextBox.Text+"'", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();

            IDTextBox.Text = String.Empty;
            ProductTxtBox.Text = String.Empty;
            PriceTxtBox.Text = String.Empty;
            QuantityTxtBox.Text = String.Empty;

            connection.Close();

            connection.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `id`, `prodname`, `barcode`, `Quantity`, `Price(GHs)` FROM `product` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            AttendantProDataGrid.DataSource = dt;
            connection.Close();*/

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
    }
}
