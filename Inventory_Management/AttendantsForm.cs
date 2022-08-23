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
    public partial class AttendantsForm : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public AttendantsForm()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            // {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `attendant` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            attendantsDataGrid.DataSource = dt;
            //  }
        }

        private void AttendantsForm_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductCatForm category = new ProductCatForm();
            category.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInterface stockInterface = new StockInterface();
            stockInterface.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (fullnameTxt.Text == "" & usernameTxt.Text == "" & passwordTxt.Text == "" & dobTxt.Text == "" & genderTxt.Text == "" & phoneTxt.Text == "" & addressTxt.Text == ""  & adminIdText.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "INSERT INTO `attendant`(`fullname`, `username`, `passwd`, `dob`, `gender`, `phone`, `address`, `admin_id`) VALUES ('" + fullnameTxt.Text + "','" + usernameTxt.Text + "','" + passwordTxt.Text + "', '" + dobTxt.Text + "', '" + genderTxt.Text + "', '" + phoneTxt.Text + "', '" + addressTxt.Text + "', '"+ adminIdText.Text + "' )";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Attendant Added Succesfully");
                    connection.Close();
                    fullnameTxt.Text = String.Empty;
                    usernameTxt.Text = String.Empty;
                    passwordTxt.Text = String.Empty;
                    dobTxt.Text = String.Empty;
                    genderTxt.Text = String.Empty;
                    phoneTxt.Text = String.Empty;
                    addressTxt.Text = String.Empty;
                    adminIdText.Text = String.Empty;

                    fullnameTxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `attendant` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                attendantsDataGrid.DataSource = dt;
            }
        }

        private void attendantsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (fullnameTxt.Text == "" & usernameTxt.Text == "" & passwordTxt.Text == "" & dobTxt.Text == "" & genderTxt.Text == "" & phoneTxt.Text == "" & addressTxt.Text == "" & adminIdText.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "DELETE FROM 'attendant' WHERE fullname ='" + fullnameTxt.Text + "' AND username = '" + usernameTxt.Text + "' ";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Attendant removed succesfully");
                    connection.Close();

                    fullnameTxt.Text = String.Empty;
                    usernameTxt.Text = String.Empty;
                    passwordTxt.Text = String.Empty;
                    dobTxt.Text = String.Empty;
                    genderTxt.Text = String.Empty;
                    phoneTxt.Text = String.Empty;
                    addressTxt.Text = String.Empty;
                    adminIdText.Text = String.Empty;

                    fullnameTxt.Focus();

                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `attendant` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                attendantsDataGrid.DataSource = dt;
                connection.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                if (fullnameTxt.Text == "" & usernameTxt.Text == "" & passwordTxt.Text == "" & dobTxt.Text == "" & genderTxt.Text == "" & phoneTxt.Text == "" & addressTxt.Text == "" & adminIdText.Text == "")
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    string query = "UPDATE `attendant` SET `fullname`='" + fullnameTxt.Text + "',`username`='" + usernameTxt.Text + "',`passwd`='" + passwordTxt.Text + "', `dob`='" + dobTxt.Text + "',`gender`='" + genderTxt.Text + "',`phone`='" + phoneTxt.Text + "', `address`='" + addressTxt.Text + "', `admin_id`='" + adminIdText.Text + "' WHERE 1";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Attendant updated succesfully");
                    connection.Close();
                    fullnameTxt.Text = String.Empty;
                    usernameTxt.Text = String.Empty;
                    passwordTxt.Text = String.Empty;
                    dobTxt.Text = String.Empty;
                    genderTxt.Text = String.Empty;
                    phoneTxt.Text = String.Empty;
                    addressTxt.Text = String.Empty;
                    adminIdText.Text = String.Empty;

                    fullnameTxt.Focus();
                }


                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `attendant` WHERE 1", connection);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                attendantsDataGrid.DataSource = dt;
                connection.Close();
            }
        }
    }
}
