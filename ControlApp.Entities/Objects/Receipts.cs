using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Receipts
    {
        public int ID_Receipt { get; set; }
        public string Customer_name { get; set; }
        public string Date_receipt { get; set; }
        public int Quantity { get; set; }

        public int ID_Price_tag { get; set; }

        public int ID_User { get; set; }

        public string Receipt_state { get; set; }


        public Receipts()
        {
            ID_Receipt = 0;
            Customer_name = null;
            Date_receipt = null;
            Quantity = 0;
            ID_Price_tag = 0;
            ID_User = 0;
            Receipt_state = null;
        }

        public Receipts(int pID_Receipt,string pCustomer_name, string pDate_receipt, int pQuantity, int pID_Price_Tag, int pID_User, string pReceipts_state )
        {
            ID_Receipt = 0;
            Customer_name = null;
            Date_receipt = null;
            Quantity = 0;
            ID_Price_tag = 0;
            ID_User = 0;
            Receipt_state = null;
        }

    }
}
