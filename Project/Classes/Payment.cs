using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Classes
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaidDate { get; set; }
        public double TotalSum { get; set; }
        public string Details { get; set; }
    }
}
