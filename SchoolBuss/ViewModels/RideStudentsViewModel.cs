using LessonMVVM.Services;
using SchoolBus_DataAccess.Repositories.Concrete;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuss.ViewModels
{
    public class RideStudentsViewModel : NotificationService
    {

        public GenericRepository<Student> StudentRep { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Student> Studentss { get; set; }
        public ObservableCollection<Ride> Rides { get; set; }
        public GenericRepository<Ride> RideRep { get; set; }
        public Ride SelectedRide {  get; set; }

        public RideStudentsViewModel()
        {
            StudentRep = new GenericRepository<Student>();
            Students = new ObservableCollection<Student>(StudentRep.GetAll().Where(s => s.RideId == null));
            RideRep = new GenericRepository<Ride>();
            Rides = new ObservableCollection<Ride>(RideRep.GetAll());
            Studentss = new ObservableCollection<Student>(StudentRep.GetAll().Where(s => s.Ride == SelectedRide));
        }
    }
}
