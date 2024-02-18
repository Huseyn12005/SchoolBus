using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class BusDTO : NotificationService
    {
        public int Id { get; set; }
        private string? Name { get; set; }
        private string? Number { get; set; }
        private int? SeatCount { get; set; }

        //Navigation Property
        private Driver? Driver { get; set; }

        public string name
        {
            get => Name;
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }

        public string number
        {
            get => Number;
            set
            {
                Number = value;
                OnPropertyChanged();
            }
        }

        public int? seatCount
        {
            get => SeatCount;
            set
            {
                SeatCount = value;
                OnPropertyChanged();
            }
        }

        public Driver? driver
        {
            get => Driver;
            set
            {
                Driver = value;
                OnPropertyChanged();
            }
        }
    }
}
