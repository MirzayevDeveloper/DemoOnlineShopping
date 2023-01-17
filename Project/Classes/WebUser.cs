using OnlineShopping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Classes
{
    public class WebUser : Customer
    {
        
        public string Login_id { get; set; }
        public string Password { get; set; }
        public string? BillingAddress { get; set; }

    }
}
