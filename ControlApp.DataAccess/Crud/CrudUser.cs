using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Crud
{
    public class CrudUser
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreateUser(User Obj)
        {
            try
            {
                Context.SP_CREATE_USER(Obj.ID_User, Obj.User_name, Obj.ID_Area);
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }
        public List<User> RetrieveAll()
        {
            List<User> MyList = new List<User>();
            try
            {
                var Query = Context.SP_RETRIEVE_ALL_USER().ToList();

                foreach (SP_RETRIEVE_ALL_USERResult Element in Query)
                {
                    User Obj = new User(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<User> Retrieve()
        {
            List<User> MyList = new List<User>();
            try
            {
                var Query = Context.SP_RETRIEVE_USER().ToList();

                foreach (SP_RETRIEVE_USERResult Element in Query)
                {
                    User Obj = new User(Element.ID_USER,Element.USER_NAMEX,Element.ID_AREA,Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {

                return MyList = null;
            }
            
        }
        public List<User> pRetrieveALL(int pID)
        {
            List<User> MyList = new List<User>();
            try
            {
                var Query = Context.SP_pRETRIEVE_ALL_USER(pID).ToList();

                foreach (SP_pRETRIEVE_ALL_USERResult Element in Query)
                {
                    User Obj = new User(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
            
            
        }
        public List<User> pRetrieve(int pID)
        {
            List<User> MyList = new List<User>();
            try
            {
                var Query = Context.SP_pRETRIEVE_USER(pID).ToList();

                foreach (SP_pRETRIEVE_USERResult Element in Query)
                {
                    User Obj = new User(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
            
        }
        public bool UpdateUser(User Obj)
        {
            try
            {
                Context.SP_UPDATE_USER(Obj.ID_User, Obj.User_name, Obj.ID_Area);
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }       
        public bool DeleteUser(int pID)
        {
            try
            {
                Context.SP_DELETE_USER(pID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
