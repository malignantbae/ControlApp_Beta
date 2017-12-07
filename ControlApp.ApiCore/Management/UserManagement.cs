using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;


namespace ControlApp.ApiCore.Management
{
    public class UserManagement : BaseManagement
    {
        public UserManagement()
        {
            _factory = new CrudUser();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateUser(User Obj)
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
        public List<T> RetrieveAllUser<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<User>();
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
        public User RetrieveUser(User Obj)
        {
            var ret = new User();
            try
            {
                //ret = _factory.Retrieve<User>(Obj);
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return ret;
        }
        public void UpdateUser(User Obj)
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
        public void DeleteUser(User Obj)
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
