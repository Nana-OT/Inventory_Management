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

            productDataGrid.DataSource = dt;
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
                if (ProdNametxt.Text == "" & categoryTxt.Text == "" & barcodetxt.Text == "" & quantitytxt.Text == "" & priceTxt.Text == "" & expTxt.Text == "" & AdminIdTxt.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "INSERT INTO `product`(`prodname`, `prod_category_id`, `barcode`, `Quantity`, `Price(GHs)`, `ExpDate`, `admin_id`) VALUES ('" + ProdNametxt.Text + "','" + categoryTxt.Text + "','" + barcodetxt.Text + "', '" + quantitytxt.Text + "', '" + priceTxt.Text + "', '" + expTxt.Text + "', '" + AdminIdTxt.Text + "' )";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product Added Succesfully");
                    connection.Close();
                    ProdNametxt.Text = String.Empty;
                    categoryTxt.Text = String.Empty;
                    barcodetxt.Text = String.Empty;
                    quantitytxt.Text = String.Empty;
                    priceTxt.Text = String.Empty;
                    expTxt.Text = String.Empty;
                    AdminIdTxt.Text = String.Empty;

                    ProdNametxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `product` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                productDataGrid.DataSource = dt;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (categoryTxt.Text == "" & ProdNametxt.Text == "" & AdminIdTxt.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "DELETE FROM product WHERE prod_category_id ='" + categoryTxt.Text + "' AND prodname = '"+ProdNametxt.Text+"' ";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Product removed succesfully");
                    connection.Close();

                    ProdNametxt.Text = String.Empty;
                    categoryTxt.Text = String.Empty;
                    barcodetxt.Text = String.Empty;
                    quantitytxt.Text = String.Empty;
                    priceTxt.Text = String.Empty;
                    expTxt.Text = String.Empty;
                    AdminIdTxt.Text = String.Empty;

                    ProdNametxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `product` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                productDataGrid.DataSource = dt;
                connection.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (ProdNametxt.Text == "" & categoryTxt.Text == "" & barcodetxt.Text == "" & quantitytxt.Text == "" & priceTxt.Text == "" & expTxt.Text == "" & AdminIdTxt.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "UPDATE `product` SET `prodname`='" + ProdNametxt.Text + "',`prod_category_id`='" + categoryTxt.Text + "',`barcode`='" + barcodetxt.Text + "',`Quantity`='" + quantitytxt.Text + "',`Price(Ghs)`='" + priceTxt.Text + "',`admin_id`='" + AdminIdTxt.Text + "' WHERE 1";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Category updated succesfully");
                    connection.Close();
                    ProdNametxt.Text = String.Empty;
                    categoryTxt.Text = String.Empty;
                    barcodetxt.Text = String.Empty;
                    quantitytxt.Text = String.Empty;
                    priceTxt.Text = String.Empty;
                    expTxt.Text = String.Empty;
                    AdminIdTxt.Text = String.Empty;

                    ProdNametxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `prodcategory` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                productDataGrid.DataSource = dt;
                connection.Close();
            }
        }
    }
}
