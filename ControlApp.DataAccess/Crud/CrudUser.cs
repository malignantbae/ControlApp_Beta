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
    public class CrudUser : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();

        public override bool Activate(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Create(BaseEntity entity)
        {
            var ObjUser = (User)entity;
            Context.SP_CRUD_USER((int)CrudActionEnum.Create, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name,ObjUser.User_email
                ,ObjUser.ID_Dpt, ObjUser.ID_area,ObjUser.ID_position,ObjUser.ID_Role,ObjUser.User_nickname,ObjUser.User_pass);
            return true;
        }

        public override bool Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
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

        public override bool Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
