using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class Parent : BaseEntity
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? Phone {  get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        //Navigation Property
        public virtual ICollection<Student>? Students { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
