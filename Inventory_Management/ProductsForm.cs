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
    public partial class ProductsForm : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public ProductsForm()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            // {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `product` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            CategoryGridView.DataSource = dt;
            //  }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (ProdNametxt.Text == "" & barcodetxt.Text == "" & quantitytxt.Text == "" & priceTxt.Text == "" & expTxt.Text == "" & AdminIdTxt.Text == "")
                {
                    MessageBox.Show("Please fill out all fields correctly");
                }
                else
                {
                    string query = "INSERT INTO `product`(`prodname`, `barcode`, `Quantity`, `Price(GHs)`, `ExpDate`, `admin_id`) VALUES ('" + ProdNametxt.Text + "','" + barcodetxt.Text + "', '" + quantitytxt.Text + "', '" + priceTxt.Text + "', '" + expTxt.Text + "', '" + AdminIdTxt.Text + "')";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Category added succesfully");
                    connection.Close();
                    ProdNametxt.Text = String.Empty;
                    barcodetxt.Text = String.Empty;
                    quantitytxt.Text = String.Empty;
                    priceTxt.Text = String.Empty;
                    expTxt.Text = String.Empty;
                    AdminIdTxt.Text = String.Empty;
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `product` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                CategoryGridView.DataSource = dt;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductCatForm category = new ProductCatForm();
            category.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendantsForm attendantsForm = new AttendantsForm();
            attendantsForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInterface stockInterface = new StockInterface();
            stockInterface.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
