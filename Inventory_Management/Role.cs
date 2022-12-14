using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Inventory_Management
{
    public partial class Role : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public Role()
        {
            InitializeComponent();
            passwordTxt.PasswordChar = '*';
        }

        private void shopRite_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (roleComboBox.SelectedItem == "Admin")
             {
                 string username, userPassword;
                 username = usernameTxt.Text;
                 userPassword = passwordTxt.Text;

                 try
                 {
                     string query = "SELECT `username`, `passwd` FROM `admin` WHERE username='" + usernameTxt.Text + "' AND passwd='" + passwordTxt.Text + "'";

                     MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                     DataTable dt = new DataTable();
                     mySqlDataAdapter.Fill(dt);

                     if (dt.Rows.Count > 0)
                     {
                         username = usernameTxt.Text;
                         userPassword = passwordTxt.Text;

                         MessageBox.Show("Login Successfull");

                         this.Hide();
                         AdminInterface admin = new AdminInterface();
                         admin.Show();
                     }
                     else
                     {
                         MessageBox.Show("Please enter a valid username or password");
                         usernameTxt.Clear();
                         passwordTxt.Clear();

                         usernameTxt.Focus();
                     }


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     connection.Close();
                 }

             }
            else if (roleComboBox.SelectedItem == "Attendant")
             {
                 string username, userPassword;
                 username = usernameTxt.Text;
                 userPassword = passwordTxt.Text;

                 try
                 {
                     string query = "SELECT `username`, `passwd` FROM `attendant` WHERE username='" + usernameTxt.Text + "' AND passwd='" + passwordTxt.Text + "'";

                     MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                     DataTable dt = new DataTable();
                     mySqlDataAdapter.Fill(dt);

                     if (dt.Rows.Count > 0)
                     {
                         username = usernameTxt.Text;
                         userPassword = passwordTxt.Text;

                       MessageBox.Show("Login Successfull");
                       this.Hide();
                       AttendantWelcome welcome = new AttendantWelcome();
                       welcome.Show();

                     }
                     else
                     {
                         MessageBox.Show("Please enter a valid username or password");
                         usernameTxt.Clear();
                         passwordTxt.Clear();

                         usernameTxt.Focus();
                     }


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     connection.Close();
                 }
             }
            else
             {
                 MessageBox.Show("Choose a valid role");
             }

        }

        private void Role_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetStartedForm getstarted = new GetStartedForm();
            getstarted.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
