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
    public class CrudCustomer
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreateCustomer(Customer Obj)
        {           
            try
            {
                Context.SP_CREATE_CUSTOMER(Obj.ID_Customer,Obj.Customer_name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Customer> RetrieveAll()
        {
            List<Customer> MyList = new List<Customer>();
            try
            {
                var Query = Context.SP_RETRIEVE_ALL_CUSTOMER().ToList();
                foreach (SP_RETRIEVE_ALL_CUSTOMERResult Element in Query)
                {
                    Customer Obj = new Customer(Element.ID_CUSTOMER,Element.CUSTOMER_NAME,Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customer> pRetrieveAll(string pName)
        {
            List<Customer> MyList = new List<Customer>();
            try
            {
                var Query = Context.SP_pRETRIEVE_ALL_CUSTOMER(pName).ToList();

                foreach (SP_pRETRIEVE_ALL_CUSTOMERResult Element in Query)
                {
                    Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customer> Retrieve()
        {
            List<Customer> MyList = new List<Customer>();
            try
            {
                var Query = Context.SP_RETRIEVE_CUSTOMER().ToList();
                foreach (SP_RETRIEVE_CUSTOMERResult Element in Query)
                {
                    Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customer> pRetrieve(string pName)
        {
            List<Customer> MyList = new List<Customer>();
            try
            {
                var Query = Context.SP_pRETRIEVE_CUSTOMER(pName).ToList();
                foreach (SP_pRETRIEVE_CUSTOMERResult Element in Query)
                {
                    Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public bool UpdateCustomer(Customer Obj)
        {            
            try
            {
                Context.SP_CREATE_CUSTOMER(Obj.ID_Customer, Obj.Customer_name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCustomer(int pID)
        {            
            try
            {
                Context.SP_DELETE_CUSTOMER(pID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
