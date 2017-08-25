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
    public class CrudAuthentication
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreateAuthentication(Authentication Obj)
        {
            try
            {
                Context.SP_CREATE_AUTHENTICATION(Obj.ID_User, Obj.User_nickname, Obj.Password, Obj.ID_Area);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public List<Authentication> Retrieve()
        {
            try
            {
                List<Authentication> MyList = new List<Authentication>();

                var Query = Context.SP_RETRIEVE_AUTHENTICATION().ToList();

                foreach (SP_RETRIEVE_AUTHENTICATIONResult Element in Query)
                {
                    Authentication Obj = new Authentication(Element.ID_USER, Element.USER_NICKNAME, Element.PASSWORD, Element.ID_AREA, Element.AUTHENTIC_STATE);
                    MyList.Add(Obj);
                }

                return MyList;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public bool UpdateAuthentication(Authentication Obj)
        {
            try
            {
                Context.SP_UPDATE_AUTHENTICATION(Obj.ID_User, Obj.User_nickname, Obj.Password, Obj.ID_Area);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
                
            }
        public bool DeleteAuthentication(int pID)
        {
            try
            {
                Context.SP_DELETE_AUTHENTICATION(pID);
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }
    }
}
