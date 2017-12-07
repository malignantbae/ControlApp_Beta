using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class CustomerManagement : BaseManagement
    {
        public CustomerManagement()
        {
            _factory = new CrudCustomer();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateCustomer(Customer Obj)
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
        public List<T> RetrieveAllCustomer<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Customer>();
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
        public Customer RetrieveCustomer(Customer Obj)
        {
            var ret = new Customer();
            try
            {
                //ret = _factory.RetrieveAll<Customer>(Obj);
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return ret;
        }
        public void UpdateCustomer(Customer Obj)
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
        public void DeleteCustomer(Customer Obj)
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