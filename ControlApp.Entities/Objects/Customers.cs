using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Customers
    {
        public int ID_Customer { get; set; }
        public string Customer_name { get; set; }
        public string Customer_state { get; set; }
        public Customers()
        {
            ID_Customer = 0;
            Customer_name = null;
            Customer_state = null;
        }
        public Customers(int pID_Customer, string pCustomer_name, string pCustomer_state)
        {
            ID_Customer = pID_Customer;
            Customer_name = pCustomer_name;
            Customer_state = pCustomer_state;
        }
    }
}
