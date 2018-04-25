using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Crud
{
    public class CrudCustomer : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public CrudCustomer()
        {
            
        }
        
        public override bool Create(BaseEntity entity)
        {
            //var Obj = (Customer)entity;
            //Context.SP_CREATE_CUSTOMER(Obj.ID_Customer, Obj.Customer_name);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();
            //List<Customer> MyList = new List<Customer>();
            //var Query = Context.SP_RETRIEVE_ALL_CUSTOMER().ToList();
            //foreach (SP_RETRIEVE_ALL_CUSTOMERResult Element in Query)
            //{

            //    Customer Obj = new Customer(Element.ID_CUSTOMER,Element.CUSTOMER_NAME,Element.CUSTOMER_STATE);
            //    MyList.Add(Obj);
            //    if (MyList.Count > 0)
            //    {
            //        foreach (var obj in MyList)
            //        {
            //            lst.Add((T)Convert.ChangeType(obj, typeof(T)));
            //        }
            //    }
            //}
            return lst;
        }
        public override bool Update(BaseEntity entity)
        {
            //var Obj = (Customer)entity;
            //Context.SP_UPDATE_CUSTOMER(Obj.ID_Customer,Obj.Customer_name);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            //var Obj = (Customer)entity;
            //Context.SP_DELETE_CUSTOMER(Obj.ID_Customer);
            return true;
        }

        public override List<T> SuperRetrieve<T>()
        {
            throw new NotImplementedException();
        }

        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> SuperRetrieveByName<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Activate(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
