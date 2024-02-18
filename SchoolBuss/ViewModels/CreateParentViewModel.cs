using LessonMVVM.Commands;
using SchoolBus_DataAccess.Repositories.Concrete;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using LessonMVVM.Services;

namespace SchoolBuss.ViewModels
{
    public class CreateParentViewModel : NotificationService
    {
        public ICommand? CreateParent { get; set; }

        private string? _Firstname;
        private string? _Lastname;
        private string? _Phone;
        private string? _Username;
        private string? _Password;

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
        public Parent Parent { get; set; }
        public GenericRepository<Parent> ParentRep { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }

        public CreateParentViewModel()
        {
            ParentRep = new GenericRepository<Parent>();
            Parents = new ObservableCollection<Parent>(ParentRep.GetAll());

            CreateParent = new RelayCommand(AddParent, Check);
        }

        private bool Check(object? parameter)
        {
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname) && !string.IsNullOrEmpty(Phone) && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                return true;
            }
            return false;
        }

        private void AddParent(object? parameter)
        {
            Parent = new()
            {
                FirstName = Firstname,
                LastName = Lastname,
                Phone = Phone,
                Username = Username,
                Password = Password
            };

            GenericRepository<Parent> ParentRep = new GenericRepository<Parent>();
            ParentRep.Add(Parent);
            Parents.Add(Parent);
            ParentRep.Save();
            MessageBox.Show("Added Succesfully!");

        }
    }
}
