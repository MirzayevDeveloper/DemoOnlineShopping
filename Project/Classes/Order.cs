using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Ordered { get; set; }
        public DateTime Shipped { get; set; }
        public string ShipTo { get; set; }
        public double TotalPrice { get; set; }
    }
}
