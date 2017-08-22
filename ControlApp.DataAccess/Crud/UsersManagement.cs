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
        public string CreateUser(Users Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_USER(Obj.ID_User, Obj.User_name, Obj.ID_Area);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
               return Message = "Error Insert" + ex;
            }
        }
        public List<Users> RetrieveAll()
        {
            List<Users> MyList = new List<Users>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_ALL_USER().ToList();

                foreach (SP_RETRIEVE_ALL_USERResult Element in Query)
                {
                    Users Obj = new Users(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Users> Retrieve()
        {
            List<Users> MyList = new List<Users>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_USER().ToList();

                foreach (SP_RETRIEVE_USERResult Element in Query)
                {
                    Users Obj = new Users(Element.ID_USER,Element.USER_NAMEX,Element.ID_AREA,Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {

                return MyList = null;
            }
            
        }
        public List<Users> pRetrieveALL(int pID)
        {
            List<Users> MyList = new List<Users>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_ALL_USER(pID).ToList();

                foreach (SP_pRETRIEVE_ALL_USERResult Element in Query)
                {
                    Users Obj = new Users(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
            
            
        }
        public List<Users> pRetrieve(int pID)
        {
            List<Users> MyList = new List<Users>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_USER(pID).ToList();

                foreach (SP_pRETRIEVE_USERResult Element in Query)
                {
                    Users Obj = new Users(Element.ID_USER, Element.USER_NAMEX, Element.ID_AREA, Element.USER_STATE);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
            
        }
        public string UpdateUser(Users Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_UPDATE_USER(Obj.ID_User, Obj.User_name, Obj.ID_Area);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }       
        public string DeleteUser(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_USER(pID);
                return Message = "Delete Complete" ;
            }
            catch (Exception ex)
            {

                return Message = "Delete Error" + ex;
            }
        }
    }
}
