using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class StockInterface : Form
    {
        public static string connectionString = "server=localhost;database=inventory_system;uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public StockInterface()
        {
            InitializeComponent();
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            // {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT `prodname`, `prod_category_id`, `barcode`, `Quantity` FROM `product` WHERE 1", connection);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);

            stockDataGrid.DataSource = dt;
            //  }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductCatForm category = new ProductCatForm();
            category.Show();
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void StockInterface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Instance of the PdfPTable class
            PdfPTable table = new PdfPTable(stockDataGrid.Columns.Count);

            //Adding header to the pdf
            for(int i = 0; i < stockDataGrid.Columns.Count; i++)
            {
                table.AddCell(new Phrase(stockDataGrid.Columns[i].HeaderText));
            }

            //Indicating the first row as the header
            table.HeaderRows = 1;

            for(int j = 0; j < stockDataGrid.Rows.Count; j++)
            {
                for(int k = 0; k < stockDataGrid.Columns.Count; k++)
                {
                    if (stockDataGrid[k, j].Value != null)
                    {
                        table.AddCell(new Phrase(stockDataGrid[k, j].Value.ToString()));
                    }
                }
            }
           
        }

        private void stockDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesReportForm salesReportForm = new SalesReportForm();
            salesReportForm.Show();
        }
    }
}
