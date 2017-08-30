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
    public class CrudReceipt
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreateUser(Receipt Obj)
        {
            try
            {
                Context.SP_CREATE_RECEIPT(Obj.Customer_name,Obj.Quantity,Obj.Total_Receipt,Obj.ID_Price_tag,Obj.ID_User);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public List<Receipt> RetrieveAll()
        {
            List<Receipt> MyList = new List<Receipt>();
            try
            {
                var Query = Context.SP_RETRIEVE_ALL_RECEIPT().ToList();
                foreach (SP_RETRIEVE_ALL_RECEIPTResult Element in Query)
                {
                    Receipt Obj = new Receipt(Element.ID_RECEIPT,Element.CUSTOMER_NAME,Element.DATE_RECEIPT,Element.QUANTITY,Element.TOTAL_RECEIPT,Element.ID_PRICE_TAG,Element.ID_USER);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Receipt> Retrieve()
        {
            List<Receipt> MyList = new List<Receipt>();
            try
            {
                var Query = Context.SP_RETRIEVE_RECEIPT().ToList();
                foreach (SP_RETRIEVE_RECEIPTResult Element in Query)
                {
                    Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Receipt> pRetrieveALL(int pID)
        {
            List<Receipt> MyList = new List<Receipt>();
            try
            {
                var Query = Context.SP_pRETRIEVE_ALL_RECEIPT(pID).ToList();
                foreach (SP_pRETRIEVE_ALL_RECEIPTResult Element in Query)
                {
                    Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }


        }
        public List<Receipt> pRetrieve(int pID)
        {
            List<Receipt> MyList = new List<Receipt>();
            try
            {
                var Query = Context.SP_pRETRIEVE_RECEIPT(pID).ToList();
                foreach (SP_pRETRIEVE_RECEIPTResult Element in Query)
                {
                    Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.CUSTOMER_NAME, Element.DATE_RECEIPT, Element.QUANTITY, Element.TOTAL_RECEIPT, Element.ID_PRICE_TAG, Element.ID_USER);
                    MyList.Add(Obj);
                }
                return MyList;
            }
            catch (Exception)
            {
                return MyList = null;
            }
        }
        public bool UpdateReceipt(Receipt Obj)
        {
            try
            {
                Context.SP_UPDATE_RECEIPT(Obj.ID_Receipt,Obj.Customer_name,Obj.Quantity,Obj.Total_Receipt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteReceipt(int pID)
        {
            try
            {
                Context.SP_DELETE_RECEIPT(pID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
