using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Receipt : BaseEntity
    {
        public int ID_Receipt { get; set; }
        public string Customer_name { get; set; }
        public DateTime Date_receipt { get; set; }
        public int Quantity { get; set; }
        public decimal Total_Receipt { get; set; }
        public int ID_Price_tag { get; set; }
        public decimal Unit_Price { get; set; }
        public Receipt()
        {
            ID_Receipt = 0;
            Customer_name = "N/A";
            Date_receipt = DateTime.Today;
            Quantity = 0;
            Total_Receipt = 0;
            ID_Price_tag = 0;
            Unit_Price = 0;
        }
        public Receipt(int pID_Receipt,string pCustomer_name, DateTime pDate_receipt, int pQuantity, decimal pTotal_Receipt, int pID_Price_Tag,decimal pUnit_Price)
        {
            this.ID_Receipt = pID_Receipt;
            this.Customer_name = pCustomer_name;
            this.Date_receipt = pDate_receipt;
            this.Quantity = pQuantity;
            this.Total_Receipt = Math.Round(pTotal_Receipt, 2);
            this.ID_Price_tag = pID_Price_Tag;
            this.Unit_Price = Math.Round(pUnit_Price, 2);
        }
        public Receipt(int pID_Receipt, string pCustomer_name, DateTime pDate_receipt, int pQuantity, decimal pTotal_Receipt, int pID_Price_Tag, decimal pUnit_Price,bool pState, string pCreateBy, string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_Receipt = pID_Receipt;
            this.Customer_name = pCustomer_name;
            this.Date_receipt = pDate_receipt;
            this.Quantity = pQuantity;
            this.Total_Receipt = Math.Round(pTotal_Receipt,2);
            this.ID_Price_tag = pID_Price_Tag;
            this.Unit_Price = Math.Round(pUnit_Price,2);
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
    }
}
