using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class DriverDTO : NotificationService
    {
        public int Id { get; set; }
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? Phone { get; set; }
        private string? Username { get; set; }
        private string? Password { get; set; }
        private string? HomeAddress { get; set; }
        private string? Licence { get; set; }

        //Foreign Key
        private int BusId { get; set; }

        //Navigation Property
        private Bus? Bus { get; set; }

        public string firstName
        {
            get => FirstName;
            set
            {
                FirstName = value;
                OnPropertyChanged();
            }
        }

        public string lastName
        {
            get => LastName;
            set
            {
                LastName = value;
                OnPropertyChanged();
            }
        }

        public string userName
        {
            get => Username;
            set
            {
                Username = value;
                OnPropertyChanged();
            }
        }

        public string password
        {
            get => Password;
            set
            {
                Password = value;
                OnPropertyChanged();
            }
        }

        public string phone
        {
            get => Phone;
            set
            {
                Phone = value;
                OnPropertyChanged();
            }
        }

        public string homeAddress
        {
            get => HomeAddress;
            set
            {
                HomeAddress = value;
                OnPropertyChanged();
            }
        }

        public string licence
        {
            get => Licence;
            set
            {
                Licence = value;
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
