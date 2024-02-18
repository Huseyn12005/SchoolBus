using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Driver : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? HomeAddress { get; set; }
        public string? Licence { get; set; }

        //Foreign Key
        public int BusId { get; set; }

        //Navigation Property
        public virtual Bus? Bus { get; set; }
    }
}
