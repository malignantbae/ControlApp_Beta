using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Authentications
    {
        public int ID_User { get; set; }
        public string  User_nickname { get; set; }
        public string Password { get; set; }

        public int ID_Area { get; set; }

        public string Authentic_State { get; set; }

        public Authentications()
        {
            ID_User = 0;
            User_nickname = null;
            Password = null;
            ID_Area = 0;
            Authentic_State = null;
        }

        public Authentications(int pID_User, string pUser_nickname, string pPassword, int pID_Area, string pAuthentic_State)
        {
            ID_User = pID_User;
            User_nickname = pUser_nickname;
            Password = pPassword;
            ID_Area = pID_Area;
            Authentic_State = pAuthentic_State;
        }


    }
}
