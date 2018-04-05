using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class User : BaseEntity
    {
        public int ID_User { get; set; }
        public string User_name { get; set; }
        public int User_phone { get; set; }
        public int User_phone_ext { get; set; }
        public string User_email { get; set; }
        public int ID_area { get; set; }
        public int ID_position { get; set; }
        public int ID_address { get; set; }
        public string User_nickname { get; set; }
        public string User_pass { get; set; }
        public User()
        {
            ID_User = 0;
            User_name = "N/A";
            User_phone = 0;
            User_phone_ext = 0;
            User_email = "N/A";
            ID_area = 0;
            ID_position = 0;
            ID_address = 0;
            User_nickname = "N/A";
            User_pass = "N/A";
        }
        public User(int pID_User, string pUser_name, int pUser_phone, int pUser_phone_ext,
            string pUser_email, int pID_area, int pID_position, int pID_ROLE, int pID_address,
            string pUser_nickname, string pUser_pass)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_phone = pUser_phone;
            this.User_phone_ext = pUser_phone_ext;
            this.User_email = pUser_email;
            this.ID_area = pID_area;
            this.ID_position = pID_position;
            this.ID_address = pID_address;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
        }
        public User(int pID_User, string pUser_name, int pUser_phone, int pUser_phone_ext,
            string pUser_email, int pID_area, int pID_position, int pID_ROLE, int pID_address,
            string pUser_nickname, string pUser_pass, bool pState, string pCreateBy, 
            string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_phone = pUser_phone;
            this.User_phone_ext = pUser_phone_ext;
            this.User_email = pUser_email;
            this.ID_area = pID_area;
            this.ID_position = pID_position;
            this.ID_address = pID_address;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
    }
}
