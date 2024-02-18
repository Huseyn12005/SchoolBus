using LessonMVVM.Commands;
using LessonMVVM.Services;
using SchoolBus_DataAccess.Repositories.Abstract;
using SchoolBus_DataAccess.Repositories.Concrete;
using SchoolBus_Models.Entities.Concrete;
using SchoolBuss.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace SchoolBuss.ViewModels
{
    class LogInViewModel : NotificationService
    {
        public ICommand? LoginCommand { get; set; }

        public IGenericRepository<Admin> AdminRepository { get; set; }

        public Admin? admin { get; set; }

        private string? _Username;

        public string Username
        {
            get { return _Username; }
            set
            {
                _Username = value;
                OnPropertyChanged();
            }
        }

        private string? _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }

        public LogInViewModel()
        {
            AdminRepository = new GenericRepository<Admin>();


            LoginCommand = new RelayCommand(Login, Check);
        }



        private bool Check(object? parameter)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                return false;
            return true;
        }
        private void Login(object? parameter)
        {
            foreach (var data in AdminRepository.GetAll())
            {
                if (Username == data.UserName && Password == data.Password)
                {
                    admin = data;
                  
                    var addView = new MainWindow();
                    addView.DataContext = new MainWindow();
                    addView.ShowDialog();

                    return;
                }
            }
        }
    }
}
