using ELibraryProject.DataAccess;
using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.LoginPageCommands
{
    public class LogInCommand : BaseCommand, ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        public LoginPageViewModel LoginPageViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LogInCommand(LoginPageViewModel LoginPageViewModel)
        {
            this.LoginPageViewModel = LoginPageViewModel;
            //MainWindowViewModel = new MainWindowViewModel();
            //MainWindowViewModel.Grid = main
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //----------------------------------------------------

            LoginPageViewModel.UserOnSystem.Password = (parameter as PasswordBox)
                .Password;

            var isExist = UnitOfWork.UserOnSystemRepository.
                IsExistUser(LoginPageViewModel.
                UserWithHashedPassword(LoginPageViewModel.UserOnSystem.Password));

            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new HomePage());

            //if (isExist)
            //{
            //    MainWindowViewModel.Grid.Children.Clear();
            //    MainWindowViewModel.Grid.Children.Add(new HomePage());
            //}
            //else
            //{
            //    MessageBoxResult mb = MessageBox.Show("Invalid username or password");
            //}

        }
    }
}
