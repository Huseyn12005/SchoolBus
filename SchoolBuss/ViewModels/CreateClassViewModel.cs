using LessonMVVM.Commands;
using LessonMVVM.Services;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using SchoolBus_DataAccess.Repositories.Concrete;

namespace SchoolBuss.ViewModels
{
    public class CreateClassViewModel : NotificationService
    {


        public ICommand CreateClass { get; set; }

        private Class _Class;

        public Class Class
        {
            get { return _Class; }
            set
            {
                _Class = value;
                OnPropertyChanged();
            }
        }


        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }


        public CreateClassViewModel()
        {

            CreateClass = new RelayCommand(AddClass, Check);

        }

        private bool Check(object? parameter)
        {
            if (string.IsNullOrEmpty(_Name)) 
                return false;
            return true;
        }

        private void AddClass(object? parameter)

        {
            Class = new()
            {
                Name = Name,
            };

            GenericRepository<Class> ClassRep = new GenericRepository<Class>();
            ClassRep.Add(Class);
            ClassRep.Save();
            MessageBox.Show("Added Succesfully!");


        }

    }
}
