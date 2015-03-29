using Razin.Bll;
using Razin.Bo;
using Razin.Dal;
namespace RazinWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RazinService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RazinService.svc or RazinService.svc.cs at the Solution Explorer and start debugging.
    public class RazinService : IRazinService
    {
        

        public void SaveEmployee(BaseEmployee emp)
        {

            RegistrationBl.SaveUserregisrationBl(emp);
            

        }
    }
}
