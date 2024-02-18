using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Student  : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? HomeAddress { get; set; }
        public string? OtherAddress { get; set; }

        //Foreign Key
        public int? ClassId { get; set; }
        public int? RideId { get; set; }
        public int? ParentId { get; set; }

        //Navigation Property
        public virtual Parent? Parent { get; set; }
        public virtual Class? Class { get; set; }
        public virtual Ride? Ride { get; set; }
    }
}
