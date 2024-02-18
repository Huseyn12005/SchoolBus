using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Bus : BaseEntity
    {
        public string? Name { get; set; }
        public string? Number { get; set; }
        public int? SeatCount { get; set; }

        //Navigation Property
        public virtual Driver? Driver { get; set; }

        public override string ToString()
        {
            return $" {Name}";
        }
    }
}
