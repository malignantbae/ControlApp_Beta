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
    public class CrudArea
    {
        ContextDataContext Context = new ContextDataContext();
        public bool CreateArea(Area Obj)
        {
            try
            {
                Context.SP_CREATE_AREA(Obj.Area_name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Area> RetrieveAll()
        {
            List<Area> MyList = new List<Area>();
            try
            {
                var Query = Context.SP_RETRIEVE_ALL_AREA().ToList();

                foreach (SP_RETRIEVE_ALL_AREAResult Element in Query)
                {
                    Area Obj = new Area(Element.ID_AREA, Element.AREA_NAME, Element.AREA_STATE);
                    MyList.Add(Obj);
                }
            }
            catch (Exception)
            {
                MyList = null;
            }
            return MyList;
        }
        public List<Area> Retrieve()
        {
            List<Area> MyList = new List<Area>();
            ContextDataContext Context = new ContextDataContext();
            var Query = Context.SP_RETRIEVE_AREA().ToList();

            foreach (SP_RETRIEVE_AREAResult Element in Query)
            {
                Area Obj = new Area(Element.ID_AREA, Element.AREA_NAME, Element.AREA_STATE);
                MyList.Add(Obj);
            }
            return MyList;
        }
        public bool UpdateArea(Area Obj)
        {            
            try
            {
                Context.SP_UPDATE_AREA(Obj.ID_Area, Obj.Area_name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteArea(int pID)
        {            
            try
            {    
                Context.SP_DELETE_AREA(pID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
