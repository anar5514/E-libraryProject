using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.UserCommands
{
    public class AddUser : ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public AddUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var user = UserViewModel.CurrentUser;
            
            user.Password = (parameter as PasswordBox).Password;

            if (user.UserName != null && user.Password != null &&
                user.Permissions != null)
            {
                var item = UserViewModel.AllUsers.FirstOrDefault(x => x.Id == user.Id);

                if (item == null)
                {
                    user.Id = UserViewModel.LastAddedUserID + 1;
                    UserViewModel.AllUsers.Add(user);
                    UserViewModel.State = 1;

                    MessageBoxResult add = MessageBox.Show("Added");
                    UserViewModel.CurrentUser = new User();
                    user = new User();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                    UserViewModel.CurrentUser = new User();
                    user = new User();
                }
            }
        }
    }
}
