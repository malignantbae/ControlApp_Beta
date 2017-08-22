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
    public class ReceiptsManagement
    {
        public string CreateUser(Receipts Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_RECEIPT(Obj.Customer_name,Obj.Date_receipt,Obj.Quantity,Obj.Total_Receipt,Obj.ID_Price_tag,Obj.ID_User);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Insert" + ex;
            }
        }
        public List<Receipts> RetrieveAll()
        {
            List<Receipts> MyList = new List<Receipts>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_ALL_RECEIPT().ToList();

                foreach (SP_RETRIEVE_ALL_RECEIPTResult Element in Query)
                {
                    Receipts Obj = new Receipts(Element.ID_RECEIPT,Element.CUSTOMER_NAME,Element.DATE_RECEIPT,Element.QUANTITY,Element.TOTAL_RECEIPT,Element.ID_PRICE_TAG,Element.ID_USER);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Receipts> Retrieve()
        {
            List<Receipts> MyList = new List<Receipts>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_RECEIPT().ToList();

                foreach (SP_RETRIEVE_RECEIPTResult Element in Query)
                {
                    Receipts Obj = new Receipts(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Receipts> pRetrieveALL(int pID)
        {
            List<Receipts> MyList = new List<Receipts>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_ALL_RECEIPT(pID).ToList();

                foreach (SP_pRETRIEVE_ALL_RECEIPTResult Element in Query)
                {
                    Receipts Obj = new Receipts(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }


        }
        public List<Receipts> pRetrieve(int pID)
        {
            List<Receipts> MyList = new List<Receipts>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_pRETRIEVE_RECEIPT(pID).ToList();

                foreach (SP_pRETRIEVE_RECEIPTResult Element in Query)
                {
                    Receipts Obj = new Receipts(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
        }
        public string UpdateReceipt(Receipts Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_UPDATE_RECEIPT(Obj.ID_Receipt,Obj.Customer_name,Obj.Date_receipt,Obj.Quantity,Obj.Total_Receipt);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public string DeleteReceipt(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_RECEIPT(pID);
                return Message = "Delete Complete";
            }
            catch (Exception ex)
            {

                return Message = "Delete Error" + ex;
            }
        }
    }
}
