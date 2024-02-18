using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Class : BaseEntity
    {
        public string? Name { get; set; }

        //Navigation Property
        public virtual ICollection<Student>? Students { get; set; }

        public override string ToString()
        {
            return $" {Name}";
        }
    }
}
