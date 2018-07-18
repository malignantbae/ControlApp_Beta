using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Order
    {
        public int Id_Order { get; set; }
        public int Id_Prepaid { get; set; }
        public int Order_Quantity { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Order_Date_Delivery { get; set; }
        /// Default Constructor
        public Order()
        {
            Id_Order = 0;
            Id_Prepaid = 0;
            Order_Quantity = 0;
            Order_Date = DateTime.Today;
            Order_Date_Delivery = DateTime.Today;
        }
        /// Constructor With parameters of DB
        public Order(int pId_Order, int pId_Prepaid, int pOrder_Quantity, DateTime Order_Date, DateTime Order_Date_Delivery, bool? pState, 
            string pCreateBy, string pUpdateBy, 
            DateTime pCreateDate, DateTime? pUpdateDate)
        {
            Id_Order = 0;
            Id_Prepaid = 0;
            Order_Quantity = 0;
            Order_Date = DateTime.Today;
            Order_Date_Delivery = DateTime.Today;
        }
    }
}
