using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace ELibraryProject.Views
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public EmployeeView(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;

            InitializeComponent();

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.LoadEmployees.Execute(null);

            DataContext = employeeViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new HomePage());
        }
    }
}
