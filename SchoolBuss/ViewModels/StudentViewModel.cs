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
    public class StudentViewModel : NotificationService
    {


        private Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; OnPropertyChanged(); }
        }

        private Class _class;

        public Class Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged(); }
        }
        public ICommand? DeleteStudent { get; set; }
        public GenericRepository<Student> StudentRep { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public GenericRepository<Parent> ParentRep { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }
        public GenericRepository<Class> ClassRep { get; set; }
        public ObservableCollection<Class> CLasses { get; set; }



        public StudentViewModel()
        {

            StudentRep = new GenericRepository<Student>();
            Students = new ObservableCollection<Student>(StudentRep.GetAll());
            ParentRep = new GenericRepository<Parent>();
            Parents = new ObservableCollection<Parent>(ParentRep.GetAll());
            ClassRep = new GenericRepository<Class>();
            CLasses = new ObservableCollection<Class>(ClassRep.GetAll());
            DeleteStudent = new RelayCommand(DeleteMethod);
        }
        private void DeleteMethod(object? parameter)
        {
            if (Student != null)
            {

               StudentRep.Remove(Student);
               Students.Remove(Student);
               StudentRep.Save();
                MessageBox.Show("Deleted Succesfully!");

            }
        }




    }
}
