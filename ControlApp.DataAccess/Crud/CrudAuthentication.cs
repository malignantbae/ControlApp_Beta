using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;
using ControlApp.DataAccess.Mapper;

namespace ControlApp.DataAccess.Crud
{
    public class CrudAuthentication : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public CrudAuthentication()
        {
            _mapper = new AuthenticationMapper();
        }
        private readonly AuthenticationMapper _mapper;
        public override bool Create(BaseEntity entity)
        {
            //var Obj = (Authentication)entity;
            //Context.SP_CREATE_AUTHENTICATION(Obj.ID_User, Obj.User_nickname, Obj.Password, Obj.ID_Area);
            //return true;
            throw new NotImplementedException();
        }
        public override List<T> RetrieveAll<T>()
        {
            //var lst = new List<T>();
            //List<Authentication> MyList = new List<Authentication>();
            //var Query = Context.SP_RETRIEVE_ALL_AUTHENTICATION().ToList();
            //foreach (SP_RETRIEVE_ALL_AUTHENTICATIONResult Element in Query)
            //{

            //    Authentication Obj = new Authentication(Element.ID_USER, Element.USER_NICKNAME, Element.PASSWORD, Element.ID_AREA, Element.AUTHENTIC_STATE);
            //    MyList.Add(Obj);
            //    if (MyList.Count > 0)
            //    {
            //        foreach (var obj in MyList)
            //        {
            //            lst.Add((T)Convert.ChangeType(obj, typeof(T)));
            //        }
            //    }
            //}
            //return lst;
            throw new NotImplementedException();
        }
        public override bool Update(BaseEntity entity)
        {
            //var Obj = (Authentication)entity;
            //Context.SP_UPDATE_AUTHENTICATION(Obj.ID_User, Obj.User_nickname, Obj.Password, Obj.ID_Area);
            //return true;
            throw new NotImplementedException();
        }
        public override bool Delete(BaseEntity entity)
        {
            //var Obj = (Authentication)entity;
            //Context.SP_DELETE_AUTHENTICATION(Obj.ID_User);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public override List<T> SuperRetrieve<T>()
        {
            throw new NotImplementedException();
        }

        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> SuperRetrieveByName<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Activate(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
