using System.Collections.Generic;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Mapper
{
    internal interface IObjectMapper
    {
        BaseEntity BuildObject(Dictionary<string, object> row);
        List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        
    }
}
