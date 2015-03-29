using Razin.Bo;
using Razin.Dal;

namespace Razin.Bll
{
   public class RegistrationBl
    {
      

       
        public static void SaveUserregisrationBl(BaseEmployee objUserBl) // passing Bussiness object Here
        {
           
            // TODO: this should be a reference to an interface
            // TODO: can we inject the dependency via a dependency injection framework like Unity or Autofac?
            Dataacess.AddEmployeeDetails(objUserBl); // calling Method of DataAccess
        }
    }
}
