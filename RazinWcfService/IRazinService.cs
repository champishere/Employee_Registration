using System.ServiceModel;
using Razin.Bo;

namespace RazinWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRazinService" in both code and config file together.
    [ServiceContract]
    public interface IRazinService
    {
        

        [OperationContract]
        void SaveEmployee(BaseEmployee emp); 
    }
}
