using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Receipt
    {
        public int ID_Receipt { get; set; }
        public string Customer_name { get; set; }
        public DateTime Date_receipt { get; set; }
        public int Quantity { get; set; }
        public decimal Total_Receipt { get; set; }
        public int ID_Price_tag { get; set; }
        public int ID_User { get; set; }
        public string Receipt_state { get; set; }
        public Receipt()
        {
            ID_Receipt = 0;
            Customer_name = null;
            Date_receipt = DateTime.Today;
            Quantity = 0;
            Total_Receipt = 0;
            ID_Price_tag = 0;
            ID_User = 0;
            Receipt_state = null;
        }
        public Receipt(int pID_Receipt,string pCustomer_name, DateTime pDate_receipt, int pQuantity, decimal pTotal_Receipt, int pID_Price_Tag, int pID_User)
        {
            this.ID_Receipt = pID_Receipt;
            this.Customer_name = pCustomer_name;
            this.Date_receipt = pDate_receipt;
            this.Quantity = pQuantity;
            this.Total_Receipt = pTotal_Receipt;
            this.ID_Price_tag = pID_Price_Tag;
            this.ID_User = pID_User;
        }
        public Receipt(string pCustomer_name, DateTime pDate_receipt, int pQuantity,decimal pTotal_Receipt, int pID_Price_Tag, int pID_User)
        {
            this.Customer_name = pCustomer_name;
            this.Date_receipt = pDate_receipt;
            this.Quantity = pQuantity;
            this.Total_Receipt = pTotal_Receipt;
            this.ID_Price_tag = pID_Price_Tag;
            this.ID_User = pID_User;
        }

    }
}
