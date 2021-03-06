﻿using ELibraryProject.DataAccess;
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
    public class UpdateUser : BaseCommand, ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateUser(UserViewModel UserViewModel)
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
            UserViewModel.AllUsers.Remove(UserViewModel.SelectedUser);
            UserViewModel.AllUsers.Add(UserViewModel.CurrentUser);
            UserViewModel.State = 3;

            UnitOfWork.UserRepository.Update(UserViewModel.CurrentUser);
            UserViewModel.CurrentUser = new User();
        }
    }
}
