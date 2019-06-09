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
        public UserViewModel UserViewModel { get; set; }

        public LogInCommand(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
            UserViewModel = new UserViewModel();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //UnitOfWork = new SqlUnitOfWork();
            //UserViewModel.UserOnSystem = new Entities.User();
            //UserViewModel.UserOnSystem.Password = (parameter as PasswordBox).Password;

            //if (UnitOfWork.UserRepository.IsExistUser(UserViewModel.UserOnSystem))
            //{
            //    MainWindowViewModel.Grid.Children.Clear();
            //    MainWindowViewModel.Grid.Children.Add(new HomePage());            
            //}
            //else
            //{
            //    MessageBoxResult mb = MessageBox.Show("Invalid username or password ...");
            //}

            //----------------------------------------------------

            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new HomePage());
        }
    }
}
