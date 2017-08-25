using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;


namespace ControlApp.ApiCore.Management
{
    public class UserManagement
    {
        CrudUser c = new CrudUser(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreateUser(User Obj)
        {
            try
            {
                c.CreateUser(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public List<User> RetrieveAll()
        {
            try
            {
                return c.RetrieveAll();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<User> Retrieve()
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
        public List<User> pRetrieveALL(int pID)
        {
            try
            {
                return c.pRetrieveALL(pID);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<User> pRetrieve(int pID)
        {
            try
            {
                return c.pRetrieve(pID);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string UpdateUser(User Obj)
        {
            try
            {
                c.UpdateUser(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public string DeleteUser(int pID)
        {
            try
            {
                c.DeleteUser(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
