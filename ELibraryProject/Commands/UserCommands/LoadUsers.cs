using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.UserCommands
{
    public class LoadUsers : BaseCommand, ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadUsers(UserViewModel UserViewModel)
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
            UserViewModel.AllUsers = new ObservableCollection<User>(UnitOfWork.UserRepository.GetAll());
        }
    }
}
