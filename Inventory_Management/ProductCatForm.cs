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
    public partial class ProductCatForm : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public ProductCatForm()
        {
            InitializeComponent();

            //using (MySqlConnection connection = new MySqlConnection(connectionString))
           // {
                connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `prodcategory` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                CategoryGridView.DataSource = dt;
                connection.Close();
          //  }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (CategoryText.Text == "" & AdminIDText.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "UPDATE `prodcategory` SET `category`='"+CategoryText.Text+"',`admin_id`='"+AdminIDText.Text+"' WHERE 1";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Category updated succesfully");
                    connection.Close();
                    CategoryText.Text = String.Empty;
                    AdminIDText.Text = String.Empty;
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `prodcategory` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                CategoryGridView.DataSource = dt;
                connection.Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (CategoryText.Text=="" & AdminIDText.Text == "")
                   {
                       MessageBox.Show("Please fill out all fields");
                   }
                else
                   {
                       string query = "INSERT INTO `prodcategory`(`category`, `admin_id`) VALUES ('" + CategoryText.Text + "','" + AdminIDText.Text + "')";
                        command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Category added succesfully");
                        connection.Close();
                        CategoryText.Text = String.Empty;
                        AdminIDText.Text = String.Empty;
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `prodcategory` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                CategoryGridView.DataSource = dt;
                connection.Close();
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (CategoryText.Text == "" )
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "DELETE FROM prodcategory WHERE category ='"+CategoryText.Text+"' ";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Category removed succesfully");
                    connection.Close();

                    CategoryText.Text = String.Empty;
                    AdminIDText.Text = String.Empty;

                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `prodcategory` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                CategoryGridView.DataSource = dt;
                connection.Close();
            }
        }

        private void ProductCatForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Refresh(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendantsForm attendantsForm = new AttendantsForm();
            attendantsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInterface stockInterface = new StockInterface();
            stockInterface.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role role = new Role();
            role.Show();
        }
    }
}
