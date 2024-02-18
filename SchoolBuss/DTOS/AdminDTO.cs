using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class AdminDTO : NotificationService
    {
        public int Id { get; set; }
        private string? FirstName;
        private string? LastName;
        private string? UserName;
        private string? Password;

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
            get => UserName;
            set
            {
                UserName = value;
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
    }
}
