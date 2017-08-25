using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class PricetagManagement
    {
        CrudPricetag c = new CrudPricetag(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreateReceipt(Price_tag Obj)
        {
            try
            {
                c.CreatePriceTag(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public List<Price_tag> RetrieveAll()
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
        public List<Price_tag> Retrieve()
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
        public string UpdateReceipt(Price_tag Obj)
        {
            try
            {
                c.UpdatePrice_Tag(Obj);
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
                c.DeletePriceTag(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
