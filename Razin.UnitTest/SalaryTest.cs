using Microsoft.VisualStudio.TestTools.UnitTesting;
using Razin.Bo;

namespace Razin.UnitTest
{
    [TestClass]
   public class SalaryTest
   {
       [TestMethod]
       public void FullTimeEemployee()
       {
           var fte = new FulltimeEmployee { Basesalary = 12 };
           var a = fte.Monthlysalary;
           Assert.AreEqual(a, 1);
       }
       [TestMethod]
       public void PartTimeEemployee()
       {
           var fte = new ParttimeEmployee { Basesalary = 12 };
           var a = fte.Monthlysalary;
           Assert.AreEqual(a, 240);
       }
    }
}
