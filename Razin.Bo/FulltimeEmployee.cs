namespace Razin.Bo
{
   public class FulltimeEmployee : BaseEmployee
    {
        //Overiden
       public override float Monthlysalary
       {
           get { return Basesalary / 12; }

       }
    }
}
