using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class ReceiptManagement
    {
        CrudReceipt c = new CrudReceipt(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreateReceipt(Receipt Obj)
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
        public List<Receipt> RetrieveAll()
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
        public List<Receipt> Retrieve()
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
        public List<Receipt> pRetrieveALL(int pID)
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
        public List<Receipt> pRetrieve(int pID)
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
        public string UpdateReceipt(Receipt Obj)
        {
            try
            {
                c.UpdateReceipt(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public string DeleteReceipt(int pID)
        {
            try
            {
                c.DeleteReceipt(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
