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
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `prodname`, `Price(GHs)` FROM `product` WHERE 1", connection);
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
        public decimal GetQuantity(int ProdID)
        {
            decimal quantity = 0;

            dt = new DataTable();
            try
            {
                string sql = "SELECT `Quantity`FROM `product` WHERE id ='"+ProdID+"'";
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

        public bool UpdateQuantity(int ProdId, decimal qty)
        {
            bool success = false;

            try
            {
                string query = "UPDATE `product` SET `Quantity`='"+qty+"' WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Quantity", qty);
                cmd.Parameters.AddWithValue("id", ProdId);

                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
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
            return success;
        }

        public bool DecreaseQuantity(int ProdId, decimal qty)
        {
            bool success = false;
            try
            {
                decimal currentQuantity = GetQuantity(ProdId);

                decimal newQty = currentQuantity - qty;

                success = UpdateQuantity(ProdId, newQty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }



            return success;
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
    }
}
