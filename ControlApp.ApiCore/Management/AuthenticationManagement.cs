using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class AuthenticationManagement : BaseManagement
    {
        CrudAuthentication c = new CrudAuthentication(); // Generate the object
        string ExcepMessage = null; // Management Exception
        public void CreateAuthentication(Authentication Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }
        public List<T> RetrieveAllAuthentication<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Authentication>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return lst;
        }
        public Authentication RetrieveAuthentication(Authentication Obj)
        {
            var ret = new Authentication();
            try
            {
                //ret = _factory.Retrieve<Authentication>(Obj);
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return ret;
        }
        public void UpdateAuthentication(Authentication Obj)
        {
            try
            {
                _factory.Update(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }
        public void DeleteAuthentication(Authentication Obj)
        {
            try
            {
                _factory.Delete(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }

    }
}
