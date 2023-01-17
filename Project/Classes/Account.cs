using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Classes
{
    public class Account
    {
        public Account(WebUser webUser)
        {
            Id = webUser.Id;
        }

        public string Id { get; private set; } 
        public bool IsClosed { get; set; }
        public DateTime Open { get; set; }
        public DateTime Closed { get; set;}
    }
}
