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
        public List<Areas> RetrieveAll()
        {
            List<Areas> MyList = new List<Areas>();
            ContextDataContext Context = new ContextDataContext();
            var Query = Context.SP_RETRIEVE_ALL_AREA().ToList();

            foreach (SP_RETRIEVE_ALL_AREAResult Element in Query)
            {
                Areas Obj = new Areas(Element.ID_AREA,Element.AREA_NAME,Element.AREA_STATE);
                MyList.Add(Obj);
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
    }
}
