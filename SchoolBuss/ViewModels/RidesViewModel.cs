using LessonMVVM.Commands;
using LessonMVVM.Services;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using SchoolBus_DataAccess.Repositories.Concrete;

namespace SchoolBuss.ViewModels
{
    public class RidesViewModel : NotificationService
    {

        private Ride _Ride;

        public Ride Ride
        {
            get { return _Ride; }
            set { _Ride = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Ride> Rides { get; set; }
        public GenericRepository<Ride> RidesRep { get; set; }

        public ICommand? DeleteRide { get; set; }
        public RidesViewModel()
        {
            RidesRep = new GenericRepository<Ride>();


            Rides = new ObservableCollection<Ride>(RidesRep?.GetAll());

            DeleteRide = new RelayCommand(DeleteMethod);
        }

        private void DeleteMethod(object? param)
        {
            if (Ride != null)
            {
                RidesRep.Remove(Ride);
                Rides.Remove(Ride);
                RidesRep.Save();
                MessageBox.Show("Deleted Succesfully!");

            }
        }

    }
}
