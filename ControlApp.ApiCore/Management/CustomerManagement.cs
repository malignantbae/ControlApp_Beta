using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class CustomerManagement
    {
        CrudCustomer c = new CrudCustomer(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreateCustomer(Customer Obj)
        {
            try
            {
                c.CreateCustomer(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public List<Customer> RetrieveAll()
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
        public List<Customer> Retrieve()
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
        public List<Customer> pRetrieve(string pNombre)
        {
            try
            {
                return c.pRetrieve(pNombre);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string UpdateCustomer(Customer Obj)
        {
            try
            {
                c.UpdateCustomer(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public string DeleteCustomer(int pID)
        {
            try
            {
                c.DeleteCustomer(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
