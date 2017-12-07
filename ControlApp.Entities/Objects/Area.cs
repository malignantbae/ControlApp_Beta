using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Area : BaseEntity 
    {
        public int ID_Area { get; set; }
        public string Area_name { get; set; }
        public Area()
        {
            ID_Area = 0;
            Area_name = null;
        }
        public Area(int pID_Area, string pArea_Name)
        {
            this.ID_Area = pID_Area;
            this.Area_name = pArea_Name;
        }
        public Area(int pID_Area,string pArea_Name, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate)
        {
            this.ID_Area = pID_Area;
            this.Area_name = pArea_Name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
        }
        public Area(int pID_Area, string pIdSession, string pArea_Name, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate)
        {
            this.ID_Area = pID_Area;
            this.IdSession = pIdSession;
            this.Area_name = pArea_Name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
        }

    }
}
