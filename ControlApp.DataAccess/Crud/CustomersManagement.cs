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
    public class CustomersManagement
    {
        public string CreateCustomer(Customers Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_CUSTOMER(Obj.ID_Customer,Obj.Customer_name);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Insert" + ex;
            }
        }
        public List<Customers> RetrieveAll()
        {
            List<Customers> MyList = new List<Customers>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_ALL_CUSTOMER().ToList();

                foreach (SP_RETRIEVE_ALL_CUSTOMERResult Element in Query)
                {
                    Customers Obj = new Customers(Element.ID_CUSTOMER,Element.CUSTOMER_NAME,Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customers> pRetrieveAll(string pName)
        {
            List<Customers> MyList = new List<Customers>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_ALL_CUSTOMER(pName).ToList();

                foreach (SP_pRETRIEVE_ALL_CUSTOMERResult Element in Query)
                {
                    Customers Obj = new Customers(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customers> Retrieve()
        {
            List<Customers> MyList = new List<Customers>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_CUSTOMER().ToList();

                foreach (SP_RETRIEVE_CUSTOMERResult Element in Query)
                {
                    Customers Obj = new Customers(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Customers> pRetrieve(string pName)
        {
            List<Customers> MyList = new List<Customers>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_CUSTOMER(pName).ToList();

                foreach (SP_pRETRIEVE_CUSTOMERResult Element in Query)
                {
                    Customers Obj = new Customers(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public string UpdateCustomer(Customers Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_CUSTOMER(Obj.ID_Customer, Obj.Customer_name);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public string DeleteCustomer(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_CUSTOMER(pID);
                return Message = "Delete Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
    }
}
