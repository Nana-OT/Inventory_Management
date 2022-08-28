using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class Receipt
    {
        public int id { get; set; }

        public string name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string Total { get { return string.Format("{0}$", Price * Quantity); } }
    }
}
