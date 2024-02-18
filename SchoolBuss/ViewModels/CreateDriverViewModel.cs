using LessonMVVM.Commands;
using LessonMVVM.Services;
using SchoolBus_DataAccess.Repositories.Concrete;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace SchoolBuss.ViewModels
{
    public class CreateDriverViewModel : NotificationService
    {

        public ICommand? CreateDriver { get; set; }

        private string? _Firstname;
        private string? _Lastname;
        private string? _Phone;
        private string? _Username;
        private string? _Password;
        private string? _HomeAddress;
        private string? _License;
        private Bus _Bus;

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; OnPropertyChanged(); }
        }

        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; OnPropertyChanged(); }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; OnPropertyChanged(); }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; OnPropertyChanged(); }
        }

        public string HomeAddress
        {
            get { return _HomeAddress; }
            set { _HomeAddress = value; OnPropertyChanged(); }
        }

        public string License
        {
            get { return _License; }
            set { _License = value; OnPropertyChanged(); }
        }

        public Bus Bus
        {
            get { return _Bus; }
            set{ _Bus = value; OnPropertyChanged();}
        }

        public GenericRepository<Bus> BusRep { get;set; }
        public ObservableCollection<Bus> Buses { get;set; }
        public Driver Driver { get;set; }

        public CreateDriverViewModel()
        {
            BusRep = new GenericRepository<Bus>();
            Buses = new ObservableCollection<Bus>(BusRep.GetAll().Where(b => b.Driver == null));
            CreateDriver = new RelayCommand(AddDriver, Check);
        }

        private bool Check(object? parameter)
        {
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname) && !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password)
                && !string.IsNullOrEmpty(HomeAddress) && !string.IsNullOrEmpty(License) && Bus != null)
            {
                return true;
            }
            return false;
        }

        private void AddDriver(object? parameter)
        {
            Driver = new()
            {
                FirstName = Firstname, 
                LastName = Lastname, 
                Phone = Phone,
                Username = Username,
                Password = Password, 
                HomeAddress = HomeAddress, 
                Licence = License, 
                BusId = Bus.Id
            };

            GenericRepository<Driver> DriverRep = new GenericRepository<Driver>();
            DriverRep.Add(Driver);
            DriverRep.Save();
            MessageBox.Show("Added Succesfully!");

        }
    }
}
