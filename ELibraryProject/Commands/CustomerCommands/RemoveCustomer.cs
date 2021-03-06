﻿using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.CustomerCommands
{
    public class RemoveCustomer : BaseCommand, ICommand
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        public RemoveCustomer(CustomerViewModel CustomerViewModel)
        {
            this.CustomerViewModel = CustomerViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CustomerViewModel.AllCustomers.Remove(CustomerViewModel.SelectedCustomer);
            CustomerViewModel.State = 2;

            UnitOfWork.CustomerRepository.Delete(CustomerViewModel.CurrentCustomer);
            CustomerViewModel.CurrentCustomer = new Customer();
        }
    }
}
