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
    public class UpdateCustomer : ICommand
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        public UpdateCustomer(CustomerViewModel CustomerViewModel)
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
            CustomerViewModel.AllCustomers.Add(CustomerViewModel.CurrentCustomer);
            CustomerViewModel.State = 3;
            CustomerViewModel.CurrentCustomer = new Customer();
        }
    }
}
