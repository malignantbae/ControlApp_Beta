using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Mapper
{
    public class PriceTagMapper : IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var pricetag = new Price_tag();
            return pricetag;
        }
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var pricetag = BuildObject(row);
                lstResults.Add(pricetag);
            }
            return lstResults;
        }
    }
}
