using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Mapper
{
    public class CustomerMapper : IObjectMapper
    {
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer();
            return customer;
        }
        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }
            return lstResults;
        }
    }
}
