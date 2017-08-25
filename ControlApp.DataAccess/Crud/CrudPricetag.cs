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
    public class CrudPricetag
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreatePriceTag(Price_tag Obj)
        {
            try
            {
                Context.SP_CREATE_PRICE_TAG(Obj.Total_Price, Obj.Descrip_Price);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Price_tag> RetrieveAll()
        {
            List<Price_tag> MyList = new List<Price_tag>();
            try
            {
                var Query = Context.SP_RETRIEVE_ALL_PRICE_TAG().ToList();

                foreach (SP_RETRIEVE_ALL_PRICE_TAGResult Element in Query)
                {
                    Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG,Element.TOTAL_PRICE,Element.DESCRIP_PRICE,Element.PRICE_TAG_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Price_tag> Retrieve()
        {
            List<Price_tag> MyList = new List<Price_tag>();
            try
            {
                var Query = Context.SP_RETRIEVE_PRICE_TAG().ToList();

                foreach (SP_RETRIEVE_PRICE_TAGResult Element in Query)
                {
                    Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;

        }
        public string UpdatePrice_Tag(Price_tag Obj)
        {
            string Message = "";
            try
            {
                Context.SP_UPDATE_PRICE_TAG(Obj.ID_Price_Tag,Obj.Total_Price,Obj.Descrip_Price);
                return Message = "Update Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public bool DeletePriceTag(int pID)
        {
            try
            {
                Context.SP_DELETE_PRICE_TAG(pID);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
