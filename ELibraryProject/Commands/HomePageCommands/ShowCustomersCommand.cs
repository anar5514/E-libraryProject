using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class ShowCustomersCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public ShowCustomersCommand(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var HasCustomerView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is CustomerView) != null;
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var CustomerView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is CustomerView);

            if (HasCustomerView)
            {
                HomePage.Visibility = Visibility.Hidden;
                CustomerView.Visibility = Visibility.Visible;
            }
            else
                MainWindowViewModel.Grid.Children.Add(new CustomerView(MainWindowViewModel));
        }
    }
}
