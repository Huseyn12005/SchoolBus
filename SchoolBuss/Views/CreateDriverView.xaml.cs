using SchoolBuss.ViewModels;
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
using System.Windows.Shapes;

namespace SchoolBuss.Views
{
    /// <summary>
    /// Interaction logic for CreateDriverView.xaml
    /// </summary>
    public partial class CreateDriverView : Window
    {
        public CreateDriverView()
        {
            InitializeComponent();
            DataContext = new CreateDriverViewModel();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CreateDriver.Close();
        }
    }
}
