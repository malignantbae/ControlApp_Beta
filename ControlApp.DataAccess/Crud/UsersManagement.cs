using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.CRUD
{
    public class UserManagement
    {
        public List<Users> RetrieveAll()
        {
            List<Users> MyList = new List<Users>();
            ContextDataContext Context = new ContextDataContext();
            var Query = Context.SP_RETRIEVE_ALL_USER().ToList();

            foreach(SP_RETRIEVE_ALL_USERResult Element in Query)
            {
                Users Obj = new Users(Element.ID_USER,Element.USER_NAME,Element.ID_AREA,Element.USER_STATE);
                MyList.Add(Obj);
            }
            return MyList;
        }
       public List<Users> Retrieve()
        {
            List<Users> MyList = new List<Users>();
            ContextDataContext Context = new ContextDataContext();
            var Query = Context.SP_RETRIEVE_USER().ToList();

            foreach (SP_RETRIEVE_USERResult Element in Query)
            {
                Users Obj = new Users(Element.ID_USER, Element.USER_NAME, Element.ID_AREA, Element.USER_STATE);
                MyList.Add(Obj);
            }
            return MyList;
        }  
    }
}
