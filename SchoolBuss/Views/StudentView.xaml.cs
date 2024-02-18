﻿using SchoolBuss.ViewModels;
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
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : Page
    {
        public StudentView()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CreateStudentView();
            window.Show();
        }
    }
}
