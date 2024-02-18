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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolBuss.Views
{
    /// <summary>
    /// Interaction logic for ParentView.xaml
    /// </summary>
    public partial class ParentView : Page
    {
        public ParentView()
        {
            InitializeComponent();
            DataContext = new ParentViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CreateParentView();
            window.Show();
        }

    }
}
