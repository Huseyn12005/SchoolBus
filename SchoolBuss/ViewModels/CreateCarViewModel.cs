using LessonMVVM.Commands;
using LessonMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using SchoolBus_Models.Entities.Concrete;
using SchoolBus_DataAccess.Repositories.Concrete;

namespace SchoolBuss.ViewModels
{
    public class CreateCarViewModel : NotificationService
    {


        public ICommand? CreateBus { get; set; }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }

        private string _Number;

        public string Number
        {
            get { return _Number; }
            set { _Number = value; OnPropertyChanged(); }
        }

        private int _SeatCount;

        public int SeatCount
        {
            get { return _SeatCount; }
            set { _SeatCount = value; OnPropertyChanged(); }
        }

        private Bus _Bus;

        public Bus Bus
        {
            get { return _Bus; }
            set
            {
                _Bus = value;
                OnPropertyChanged();
            }
        }

        public CreateCarViewModel()
        {
            CreateBus = new RelayCommand(AddBus, Check);
        }
        private bool Check(object? parameter)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Number) && SeatCount > 0)
            {
                return true;
            }
            return false;
        }

        private void AddBus(object? parameter)
        {
            Bus = new()
            {
                Name = Name,
                Number = Number,
                SeatCount = SeatCount
            };

            GenericRepository<Bus> BusRep = new GenericRepository<Bus>();
            BusRep.Add(Bus);
            BusRep.Save();
            MessageBox.Show("Added Succesfully!");


        }

    }
}

