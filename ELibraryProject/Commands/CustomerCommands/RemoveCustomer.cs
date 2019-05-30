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
    public class RemoveCustomer : ICommand
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        public RemoveCustomer(CustomerViewModel CustomerViewModel)
        {
            this.CustomerViewModel = CustomerViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CustomerViewModel.AllCustomers.Remove(CustomerViewModel.SelectedCustomer);
            CustomerViewModel.CurrentCustomer = new Customer();
            CustomerViewModel.State = 2;
        }
    }
}
