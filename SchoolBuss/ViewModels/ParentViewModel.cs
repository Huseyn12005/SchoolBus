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


    public class ParentViewModel : NotificationService
    {
        public ICommand? DeleteParent { get; set; }
        private Parent _Parent;

        public Parent Parent
        {
            get { return _Parent; }
            set { _Parent = value; OnPropertyChanged(); }
        }

        public GenericRepository<Parent> ParentRep { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }




        public ParentViewModel()
        {

            ParentRep = new GenericRepository<Parent>();
            Parents = new ObservableCollection<Parent>(ParentRep.GetAll());

            DeleteParent = new RelayCommand(Delete);
        }



        private void Delete(object? parameter)
        {
            ParentRep.Remove(Parent);
            Parents.Remove(Parent);
            ParentRep.Save();

            MessageBox.Show("Deleted Succesfully!");

        }
    }

       
}
