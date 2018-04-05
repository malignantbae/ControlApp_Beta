using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Address : BaseEntity
    {
        public int ID_Address { get; set; }
        public string Descrip_address { get; set; }
        
        public Address()
        {
            ID_Address = 0;
            Descrip_address = "N/A";
        }
       



    }
}
