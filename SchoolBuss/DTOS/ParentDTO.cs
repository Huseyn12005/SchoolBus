using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class ParentDTO : NotificationService
    {
        public int Id { get; set; }
        private string? FirstName {  get; set; }
        private string? LastName { get; set; }
        private string? Phone {  get; set; }
        private string? Username { get; set; }
        private string? Password { get; set; }

        //Navigation Property
        private ICollection<Student>? Students { get; set; }

        public string? firstName
        {
            get => FirstName;
            set
            {
                FirstName = value;
                OnPropertyChanged();
            }
        }

        public string? lastName
        {
            get => LastName;
            set
            {
                LastName = value;
                OnPropertyChanged();
            }
        }

        public string? username
        {
            get => Username;
            set
            {
                Username = value;
                OnPropertyChanged();
            }
        }

        public string? password
        {
            get => Password;
            set
            {
                Password = value;
                OnPropertyChanged();
            }
        }

        public string? phone
        {
            get => Phone;
            set
            {
                Phone = value;
                OnPropertyChanged();
            }
        }

        public ICollection<Student>? students
        {
            get => Students;
            set
            {
                Students = value;
                OnPropertyChanged();
            }
        }
    }
}
