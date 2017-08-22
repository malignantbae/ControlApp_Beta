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
    public class PricetagsManagement
    {
        public string CreatePriceTag(Price_tags Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_PRICE_TAG(Obj.Total_Price, Obj.Descrip_Price);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Insert" + ex;
            }
        }
        public List<Price_tags> RetrieveAll()
        {
            List<Price_tags> MyList = new List<Price_tags>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_ALL_PRICE_TAG().ToList();

                foreach (SP_RETRIEVE_ALL_PRICE_TAGResult Element in Query)
                {
                    Price_tags Obj = new Price_tags(Element.ID_PRICE_TAG,Element.TOTAL_PRICE,Element.DESCRIP_PRICE,Element.PRICE_TAG_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Price_tags> Retrieve()
        {
            List<Price_tags> MyList = new List<Price_tags>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_PRICE_TAG().ToList();

                foreach (SP_RETRIEVE_PRICE_TAGResult Element in Query)
                {
                    Price_tags Obj = new Price_tags(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;

        }
        public string UpdatePrice_Tag(Price_tags Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_UPDATE_PRICE_TAG(Obj.ID_Price_Tag,Obj.Total_Price,Obj.Descrip_Price);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public string DeletePriceTag(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_PRICE_TAG(pID);
                return Message = "Delete Complete";
            }
            catch (Exception ex)
            {

                return Message = "Delete Error" + ex;
            }
        }

    }
}
