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
    public class AreasManagement
    {
        public string CreateArea(Areas Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_CREATE_AREA(Obj.Area_name);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Insert" + ex;
            }
        }
        public List<Areas> RetrieveAll()
        {
            List<Areas> MyList = new List<Areas>();
            try
            {
                ContextDataContext Context = new ContextDataContext();
                var Query = Context.SP_RETRIEVE_ALL_AREA().ToList();

                foreach (SP_RETRIEVE_ALL_AREAResult Element in Query)
                {
                    Areas Obj = new Areas(Element.ID_AREA, Element.AREA_NAME, Element.AREA_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Areas> Retrieve()
        {
            List<Areas> MyList = new List<Areas>();
            ContextDataContext Context = new ContextDataContext();
            var Query = Context.SP_RETRIEVE_AREA().ToList();

            foreach (SP_RETRIEVE_AREAResult Element in Query)
            {
                Areas Obj = new Areas(Element.ID_AREA, Element.AREA_NAME, Element.AREA_STATE);
                MyList.Add(Obj);
            }
            return MyList;
        }
        public string UpdateArea(Areas Obj)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_UPDATE_AREA(Obj.ID_Area, Obj.Area_name);
                return Message = "Insert Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
        public string DeleteArea(int pID)
        {
            string Message = "";
            try
            {
                ContextDataContext Context = new ContextDataContext();
                Context.SP_DELETE_AREA(pID);
                return Message = "Delete Complete";
            }
            catch (Exception ex)
            {
                return Message = "Error Update" + ex;
            }
        }
    }
}
