using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class RideDTO : NotificationService
    {
        public int Id { get; set; }
        private string? FullName { get; set; }

        //Foreign Key
        private int BusId { get; set; }
       
        //Navigation Property
        private ICollection<Student>? Students { get; set; }
        private Bus? Bus { get; set; }


        public string fullname
        {
            get => FullName;
            set
            {
                FullName = value;
                OnPropertyChanged();
            }
        }

        public int busId
        {
            get => BusId;
            set
            {
                BusId = value;
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

        public Bus bus
        {
            get => Bus;
            set
            {
                Bus = value;
                OnPropertyChanged();
            }
        }
    }
}
