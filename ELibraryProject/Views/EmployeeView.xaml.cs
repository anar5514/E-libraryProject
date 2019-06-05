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

            DataContext = new EmployeeViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var EmployeeView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is EmployeeView);

            EmployeeView.Visibility = Visibility.Hidden;
            HomePage.Visibility = Visibility.Visible;
        }
    }
}
