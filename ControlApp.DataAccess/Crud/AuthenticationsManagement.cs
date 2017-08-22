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
    public class AuthenticationsManagement
    {
        public string CreateAuthentication(Authentications Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_AUTHENTICATION(Obj.ID_User, Obj.User_nickname, Obj.Password, Obj.ID_Area);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Insert" + ex;
            }
        }
        public List<Authentications> Retrieve()
        {
            List<Authentications> MyList = new List<Authentications>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_AUTHENTICATION().ToList();

                foreach (SP_RETRIEVE_AUTHENTICATIONResult Element in Query)
                {
                    Authentications Obj = new Authentications(Element.ID_USER,Element.USER_NICKNAME,Element.PASSWORD,Element.ID_AREA,Element.AUTHENTIC_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public string UpdateAuthentication(Authentications Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_UPDATE_AUTHENTICATION(Obj.ID_User,Obj.User_nickname,Obj.Password,Obj.ID_Area);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public string DeleteAuthentication(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_AUTHENTICATION(pID);
                return Message = "Delete Complete";
            }
            catch (Exception ex)
            {

                return Message = "Delete Error" + ex;
            }
        }
    }
}
