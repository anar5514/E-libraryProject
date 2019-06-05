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
    public class ShowEmployeesCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public ShowEmployeesCommand(MainWindowViewModel MainWindowViewModel)
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
            var HasEmployeeView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                 .FirstOrDefault(x => x is EmployeeView) != null;
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var EmployeeView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is EmployeeView);

            if (HasEmployeeView)
            {
                HomePage.Visibility = Visibility.Hidden;
                EmployeeView.Visibility = Visibility.Visible;
            }
            else
                MainWindowViewModel.Grid.Children.Add(new EmployeeView(MainWindowViewModel));
        }
    }
}
