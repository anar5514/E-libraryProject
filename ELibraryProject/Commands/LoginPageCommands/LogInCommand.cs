using ELibraryProject.DataAccess;
using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.LoginPageCommands
{
    public class LogInCommand : BaseCommand, ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LogInCommand(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainWindowViewModel.Helper = new Security.Helper();
            var helper = MainWindowViewModel.Helper;

            var cleanPassword = (parameter as PasswordBox).Password;
            var hashPassword = helper.GetHashPassword(cleanPassword);
            MainWindowViewModel.UserOnSystem.Password = hashPassword;

            var user = UnitOfWork.UserOnSystemRepository.
                GetUser(MainWindowViewModel.UserOnSystem);

            if (user != null)
            {
                App.UserOnSystem = user;
                MainWindowViewModel.UserOnSystem = user;
                MainWindowViewModel.Grid.Children.Clear();
                MainWindowViewModel.Grid.Children.Add(new HomePage());
            }
            else
            {
                //MainWindowViewModel.Grid.Children.Clear();
                //MainWindowViewModel.Grid.Children.Add(new HomePage());
                MessageBoxResult mb = MessageBox.Show("Invalid username or password");
                MainWindowViewModel.UserOnSystem = new Entities.User();
            }


        }
    }
}
