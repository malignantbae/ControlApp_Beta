using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class AuthenticationManagement
    {
        CrudAuthentication c = new CrudAuthentication(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreatAuthentication(Authentication Obj)
        {
            try
            {
                c.CreateAuthentication(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public List<Authentication> Retrieve()
        {
            try
            {
                return c.Retrieve();
            }
            catch (Exception)
            {

                return null;
            }

        }
        public string UpdateAuthentication(Authentication Obj)
        {
            try
            {
                c.UpdateAuthentication(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public string DeleteAuthentication(int pID)
        {
            try
            {
                c.DeleteAuthentication(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
