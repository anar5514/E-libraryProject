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
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            UserViewModel.AllUsers.Remove(UserViewModel.SelectedUser);
            UserViewModel.CurrentUser = new User();
            UserViewModel.State = 2;

            //UnitOfWork = new SqlUnitOfWork();
            //UnitOfWork.UserRepository.Delete(UserViewModel.CurrentUser);
            //UnitOfWork.SaveChanges();
        }
    }
}
