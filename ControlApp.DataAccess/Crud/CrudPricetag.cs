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
    public class CrudPricetag : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Price_tag ObjPrice_Tag = new Price_tag();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Price_tag)entity;
            Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.Create,Obj.IdSession, Obj.ID_Price_Tag, Obj.Total_Price, Obj.Descrip_Price);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.RetrieveAll, ObjPrice_Tag.IdSession,
               ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override bool Update(BaseEntity entity)
        {
            var Obj = (Price_tag)entity;
            Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.Update, Obj.IdSession, Obj.ID_Price_Tag, Obj.Total_Price, Obj.Descrip_Price);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Price_tag)entity;
            Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.Delete, Obj.IdSession, Obj.ID_Price_Tag, Obj.Total_Price, Obj.Descrip_Price);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.SuperRetrieve, ObjPrice_Tag.IdSession,
                ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE, Element.PRICE_TAG_STATE,
                    Element.PRICE_TAG_CREATEBY,Element.PRICE_TAG_UPDATEDBY,Element.PRICE_TAG_CREATEDATE,Element.PRICE_TAG_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            var ObjPrice_Tag = (Price_tag)entity;
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.SuperRetrieveById, ObjPrice_Tag.IdSession,
               ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE, Element.PRICE_TAG_STATE,
                    Element.PRICE_TAG_CREATEBY, Element.PRICE_TAG_UPDATEDBY, Element.PRICE_TAG_CREATEDATE, Element.PRICE_TAG_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveByName<T>(BaseEntity entity)
        {
            var ObjPrice_Tag = (Price_tag)entity;
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.SuperRetrieveByName, ObjPrice_Tag.IdSession,
               ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE, Element.PRICE_TAG_STATE, 
                    Element.PRICE_TAG_CREATEBY, Element.PRICE_TAG_UPDATEDBY, Element.PRICE_TAG_CREATEDATE, Element.PRICE_TAG_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveById<T>(BaseEntity entity)
        {
            var ObjPrice_Tag = (Price_tag)entity;
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.RetrieveById, ObjPrice_Tag.IdSession,
               ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            var ObjPrice_Tag = (Price_tag)entity;
            var lst = new List<T>();
            List<Price_tag> MyList = new List<Price_tag>();
            var Query = Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.RetrieveByName, ObjPrice_Tag.IdSession,
               ObjPrice_Tag.ID_Price_Tag, ObjPrice_Tag.Total_Price, ObjPrice_Tag.Descrip_Price).ToList();
            foreach (SP_CRUD_PRICE_TAGResult Element in Query)
            {
                Price_tag Obj = new Price_tag(Element.ID_PRICE_TAG, Element.TOTAL_PRICE, Element.DESCRIP_PRICE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override bool Activate(BaseEntity entity)
        {
            var Obj = (Price_tag)entity;
            Context.SP_CRUD_PRICE_TAG((int)CrudActionEnum.Activate, Obj.IdSession, Obj.ID_Price_Tag, Obj.Total_Price, Obj.Descrip_Price);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
