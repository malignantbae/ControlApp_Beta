using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Users
    {
        public int ID_User { get; set; }
        public string User_name { get; set; }
        public int ID_Area { get; set; }
        public string User_state { get; set; }
        public Users()
        {
            ID_User = 0;
            User_name = null;
            ID_Area = 0;
            User_state = null;
        }
        public Users(int pID_User, string pUser_name, int pID_Area, string pUser_state)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.ID_Area = pID_Area;
            this.User_state = pUser_name;
        }
    }
}
