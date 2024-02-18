using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Ride : BaseEntity
    {
        public string? FullName { get; set; }

        //Foreign Key
        public int? BusId { get; set; }
       
        //Navigation Property
        public virtual ICollection<Student>? Students { get; set; }
        public virtual Bus? Bus { get; set; }

        public override string ToString()
        {
            return $" {FullName}";
        }
    }
}
