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
            throw new NotImplementedException();
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
    }
}
