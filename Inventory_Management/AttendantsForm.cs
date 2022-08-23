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
        public AttendantsForm()
        {
            InitializeComponent();
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
    }
}
