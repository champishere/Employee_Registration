using System;
using System.Runtime.Serialization;

namespace Razin.Bo
{
    [KnownType(typeof(FulltimeEmployee))]
    [KnownType(typeof(ParttimeEmployee))]
    [DataContract]
   public class BaseEmployee
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string MobileNumber { get; set; }
        [DataMember]
        public string Designation { get; set; }
        [DataMember]
        public float Basesalary { get; set; }
        [DataMember]
        public string Emptype { get; set; }
    [DataMember]
   public float MonthlySalary { get; set; }


//        // TODO: how is this distinct from MonthlySalary - if it is, WHY is it distinct? the class name should reflect this difference
        public virtual float Monthlysalary
        {
            get { throw new NotImplementedException(); }
        }
    }
}
