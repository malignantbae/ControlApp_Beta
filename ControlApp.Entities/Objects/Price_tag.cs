using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Price_tag : BaseEntity
    {
        public int ID_Price_Tag { get; set; }
        public decimal Total_Price { get; set; }
        public string Descrip_Price { get; set; }
        public Price_tag()
        {
            ID_Price_Tag = 0;
            Total_Price = 0;
            Descrip_Price = "Null";
        
        }
        public Price_tag(int pID_Price_Tag, decimal pTotal_Price, string pDescrip_Price)
        {
            this.ID_Price_Tag = pID_Price_Tag;
            this.Total_Price = pTotal_Price;
            this.Descrip_Price = pDescrip_Price;
        }
        public Price_tag(int pID_Price_Tag, decimal pTotal_Price, string pDescrip_Price, bool pState, string pCreateBy, string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_Price_Tag = pID_Price_Tag;
            this.Total_Price = pTotal_Price;
            this.Descrip_Price = pDescrip_Price;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
        public Price_tag(int pID_Price_Tag,string pIdSession, decimal pTotal_Price, string pDescrip_Price, bool pState, string pCreateBy, string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_Price_Tag = pID_Price_Tag;
            this.IdSession = pIdSession;
            this.Total_Price = pTotal_Price;
            this.Descrip_Price = pDescrip_Price;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
    }

}
