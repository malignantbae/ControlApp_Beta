using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Areas
    {
        public int ID_Area { get; set; }
        public string Area_name { get; set; }
        public string Area_state { get; set; }
        public Areas()
        {
            ID_Area = 0;
            Area_name = null;
            Area_state = null;
        }
        public Areas(int pID_Area, string pArea_Name, string pArea_state )
        {
            this.ID_Area = pID_Area;
            this.Area_name = pArea_Name;
            this.Area_state = pArea_state;
        }
    }
}
