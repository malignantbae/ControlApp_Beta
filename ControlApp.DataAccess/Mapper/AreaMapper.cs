using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Mapper
{
    public class AreaMapper : IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var area = new Area();
            return area;
        }
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var area = BuildObject(row);
                lstResults.Add(area);
            }
            return lstResults;
        }

        ///TRY TO READ ME
    }
}
