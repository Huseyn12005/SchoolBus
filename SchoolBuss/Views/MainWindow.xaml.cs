using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolBuss.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            mainFrame.Navigate(new Uri("Views/RideStudentsView.xaml", UriKind.Relative));
        }

        private void Rides_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/RidesView.xaml", UriKind.Relative));
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/StudentView.xaml", UriKind.Relative));
        }

        private void Parent_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/ParentView.xaml", UriKind.Relative));
        }


        private void Car_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/CarView.xaml", UriKind.Relative));
        }

        private void Driver_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/DriverView.xaml", UriKind.Relative));
        }

        private void SearchTxtBx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CreateRide_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/RideStudentsView.xaml", UriKind.Relative));
        }

        private void Class_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("Views/ClassView.xaml", UriKind.Relative));
        }
    }
}
