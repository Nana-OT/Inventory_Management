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
    public partial class SalesReportForm : Form
    {

        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public SalesReportForm()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            // {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM `sales` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            salesHistoryDataGrid.DataSource = dt;
            //  }
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInterface stockInterface = new StockInterface();
            stockInterface.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendantsForm attendantsForm = new AttendantsForm();
            attendantsForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductCatForm category = new ProductCatForm();
            category.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Confirm!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("You are logged out!");
                this.Hide();
                Role role = new Role();
                role.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Logout cancelled succesfully! ");
                this.Refresh();
            }
        }
    }
}
