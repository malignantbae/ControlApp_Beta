using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Price_tag
    {
        public int ID_Price_Tag { get; set; }
        public decimal Total_Price { get; set; }
        public string Descrip_Price { get; set; }
        public string Price_Tag_State { get; set; }
        public Price_tag()
        {
            ID_Price_Tag = 0;
            Total_Price = 0;
            Descrip_Price = null;
            Price_Tag_State = null;
        }
        public Price_tag(int pID_Price_Tag, decimal pTotal_Price, string pDescrip_Price, string pPrice_Tag_State)
        {
            this.ID_Price_Tag = 0;
            this.Total_Price = 0;
            this.Descrip_Price = null;
            this.Price_Tag_State = null;
        }
        public Price_tag(int pID_Price_Tag, decimal pTotal_Price, string pDescrip_Price)
        {
            this.ID_Price_Tag = 0;
            this.Total_Price = 0;
            this.Descrip_Price = null;
            
        }
    }

}
