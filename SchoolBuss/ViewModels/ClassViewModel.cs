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
    public class ClassViewModel : NotificationService
    {

        private Class _class;

        public Class _Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged(); }
        }

        public ICommand? DeleteClass { get; set; }

        public ObservableCollection<Class> Classes { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public GenericRepository<Class> ClassRep { get; set; }


        public ClassViewModel()
        {
            ClassRep = new GenericRepository<Class>();
            Classes = new ObservableCollection<Class>(ClassRep.GetAll());

            DeleteClass = new RelayCommand(DeleteMethod);
        }

        private void DeleteMethod(object? parameter)
        {
            if (_Class != null)
            {

               ClassRep.Remove(_Class);
               Classes.Remove(_Class);
               ClassRep.Save();
                MessageBox.Show("Deleted Succesfully!");
            }
        }

    }
}
