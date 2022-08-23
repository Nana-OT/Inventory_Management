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
        public StockInterface()
        {
            InitializeComponent();
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
    }
}
