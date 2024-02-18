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
using System.Windows.Input;
using System.Windows;

namespace SchoolBuss.ViewModels
{
    public class CreateStudentViewModel : NotificationService
    {
        public ICommand? CreateStudent { get; set; }

        private string? _Firstname;
        private string? _Lastname;
        private Parent _Parent;
        private Class _Class;
        private string? _Address1;
        private string? _Address2;

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

        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; OnPropertyChanged(); }
        }

        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; OnPropertyChanged(); }
        }

        public Parent Parent
        {
            get { return _Parent; }
            set { _Parent = value; OnPropertyChanged(); }
        }

        public Class Class
        {
            get { return _Class; }
            set { _Class = value; OnPropertyChanged(); }
        }

        public GenericRepository<Parent> ParentRep { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }

        public GenericRepository<Class> ClassRep { get; set; }
        public ObservableCollection<Class> Classes { get; set; }
        public Student Student { get; set; }

        public CreateStudentViewModel()
        {
            ParentRep = new GenericRepository<Parent>();
            Parents = new ObservableCollection<Parent>(ParentRep.GetAll());
            ClassRep = new GenericRepository<Class>();
            Classes = new ObservableCollection<Class>(ClassRep.GetAll());
            CreateStudent = new RelayCommand(AddStudent, Check);
        }

        private bool Check(object? parameter)
        {
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname) && !string.IsNullOrEmpty(Address1) && !string.IsNullOrEmpty(Address2) && Parent != null
                && Class != null)
            {
                return true;
            }
            return false;
        }

        private void AddStudent(object? parameter)
        {
            Student = new()
            {
                FirstName = Firstname,
                LastName = Lastname,
                HomeAddress = Address1,
                OtherAddress = Address2,
                ClassId = Class.Id,
                ParentId = Parent.Id,
            };

            GenericRepository<Student> StudentRep = new GenericRepository<Student>();
            StudentRep.Add(Student);
            StudentRep.Save();
            MessageBox.Show("Added Succesfully!");

        }
    }
}
