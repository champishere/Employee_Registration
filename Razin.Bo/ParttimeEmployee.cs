namespace Razin.Bo
{
   public class ParttimeEmployee : BaseEmployee
    {
        //Overiden
       public override float Monthlysalary
        {
            get { return Basesalary * 20; } 
        }
    }
}
