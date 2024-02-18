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
    public class DriverViewModel : NotificationService
    {


        private Driver _Driver;

        public Driver Driver
        {
            get { return _Driver; }
            set { _Driver = value; OnPropertyChanged(); }
        }

        public ICommand? DeleteDriver { get; set; }

        public ObservableCollection<Driver> Drivers { get; set; }
        public ObservableCollection<Ride> Rides { get; set; }
        public GenericRepository<Ride> RideRep { get; set; }
        public GenericRepository<Driver> DriverRep { get; set; }


        public DriverViewModel()
        {
            DriverRep = new GenericRepository<Driver>();
            RideRep = new GenericRepository<Ride>();
            Drivers = new ObservableCollection<Driver>(DriverRep.GetAll());
            Rides = new ObservableCollection<Ride>(RideRep.GetAll());

            DeleteDriver = new RelayCommand(DeleteMethod);
        }

        private void DeleteMethod(object? PARAMETER)
        {
            if (Driver != null)
            {

                DriverRep.Remove(Driver);
                Drivers.Remove(Driver);
                DriverRep.Save();
                MessageBox.Show("Deleted Succesfully!");
            }
        }

    }
}
