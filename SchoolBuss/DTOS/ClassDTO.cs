using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class ClassDTO : NotificationService
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //Navigation Property
        private ICollection<Student>? Students { get; set; }

        public string name
        {
            get => Name;
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }

        public ICollection<Student> students
        {
            get => Students;
            set
            {
                Students = value;
                OnPropertyChanged();
            }
        }
    }
}
