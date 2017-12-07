using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class PricetagManagement : BaseManagement
    {
       public PricetagManagement()
        {
            _factory = new CrudPricetag();
        }
        string ExcepMessage = null; // Management Exception

        public void CreatePriceTag(Price_tag Obj)
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
        public List<T> SuperRetrievePriceTag<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Price_tag>();
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
        public List<T> SuperRetrieveAllByIdPrice<T>(Price_tag Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Price_tag>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> SuperRetrieveAllByNameDescrip<T>(Price_tag Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Price_tag>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> RetrieveAllPriceTag<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Price_tag>();
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
        public List<T> RetrieveAllByNameDescrip<T>(Price_tag Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Price_tag>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> RetrieveAllByIdPriceTag<T>(Price_tag Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Price_tag>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public void UpdatePriceTag(Price_tag Obj)
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
        public void DeletePriceTag(Price_tag Obj)
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
        public void ActivatePriceTag(Price_tag Obj)
        {
            try
            {
                _factory.Activate(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }

    }
}
