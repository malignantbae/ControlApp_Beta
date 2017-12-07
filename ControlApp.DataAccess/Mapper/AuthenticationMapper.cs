using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Mapper 
{
    public class AuthenticationMapper : IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var authentication = new Authentication();
            return authentication;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var authentication = BuildObject(row);
                lstResults.Add(authentication);
            }
            return lstResults;
        }
    }
}
