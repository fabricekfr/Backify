using System.Collections.Generic;

namespace ClientModel
{
    public interface IDataService
    {
        IEnumerable<IWeightRecord> GetData(object argument);
    }
}
