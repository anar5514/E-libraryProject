using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.UserCommands
{
    public class RemoveUser : BaseCommand, ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public RemoveUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UserViewModel.AllUsers.Remove(UserViewModel.SelectedUser);
            UserViewModel.State = 2;

            UnitOfWork.UserRepository.Delete(UserViewModel.CurrentUser);
            UserViewModel.CurrentUser = new User();
        }
    }
}
