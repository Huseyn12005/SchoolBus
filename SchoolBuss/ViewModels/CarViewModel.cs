using Castle.Core.Internal;
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
    public class CarViewModel : NotificationService
    {


        private Bus _bus;

        public Bus Bus
        {
            get { return _bus; }
            set { _bus = value; OnPropertyChanged(); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged(); }
        }
        private string _seatCount;

        public string SeatCount
        {
            get { return _seatCount; }
            set { _seatCount = value; OnPropertyChanged(); }
        }
        public ICommand? DeleteCar { get; set; }



        private ObservableCollection<Bus> _Buses;

        public ObservableCollection<Bus> Buses
        {
            get { return _Buses; }
            set { _Buses = value; OnPropertyChanged(); }
        }


        public ObservableCollection<Ride> Rides { get; set; }
        public GenericRepository<Bus> BusesRep { get; set; }
        public GenericRepository<Ride> RidesRep { get; set; }

        public CarViewModel()
        {

            BusesRep = new GenericRepository<Bus>();
            RidesRep = new GenericRepository<Ride>();
            Rides = new ObservableCollection<Ride>(RidesRep.GetAll());
            Buses = new ObservableCollection<Bus>(BusesRep.GetAll());
            DeleteCar = new RelayCommand(DeleteMethod);


        }
        private void DeleteMethod(object? param)
        {
            if (Bus != null)
            {

                BusesRep.Remove(Bus);
                Buses.Remove(Bus);
                BusesRep.Save();
                MessageBox.Show("Deleted Succesfully!");
            }
        }



    }
}
