using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class AreaManagement
    {
        CrudArea c = new CrudArea(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public string CreateArea(Area Obj)
        {
            try
            {
                c.CreateArea(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public List<Area> RetrieveAll()
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
        public List<Area> Retrieve()
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
        public string UpdateArea(Area Obj)
        {
            try
            {
                c.UpdateArea(Obj);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
        public string DeleteArea(int pID)
        {
            try
            {
                c.DeleteArea(pID);
            }
            catch (Exception ex)
            {
                return ExcepMessage = "Logic Error" + ex;
            }
            return ExcepMessage;
        }
    }
}
