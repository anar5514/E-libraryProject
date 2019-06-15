using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.Security;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.UserCommands
{
    public class AddUser : BaseCommand, ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var user = UserViewModel.CurrentUser;


            if (user.UserName != null && (parameter as PasswordBox).Password != null)
            {
                Helper helper = new Helper();
                user.Password = helper.GetHashPassword((parameter as PasswordBox).Password);

                UnitOfWork.UserRepository.Add(UserViewModel.CurrentUser);
                UserViewModel.AllUsers.Add(UserViewModel.CurrentUser);
                UserViewModel.State = 1;

                MessageBoxResult add = MessageBox.Show("Added");
                UserViewModel.CurrentUser = new User();
                
            }
        }
    }
}
