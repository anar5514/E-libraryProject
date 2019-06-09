using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.CustomerCommands
{
    public class AddCustomer : BaseCommand, ICommand
    {
        public CustomerViewModel CustomerViewModel { get; set; }

        public AddCustomer(CustomerViewModel CustomerViewModel)
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
            var zz = CustomerViewModel.CurrentCustomer;

            if (zz.Name != null && zz.Surname != null && zz.PhoneNumber != null &&
                zz.JoinedDate.Date != null)
            {

                var item = CustomerViewModel.AllCustomers.FirstOrDefault(x => x.Id == CustomerViewModel.CurrentCustomer.Id);

                if (item == null)
                {
                    
                    UnitOfWork.CustomerRepository.Add(CustomerViewModel.CurrentCustomer);

                    CustomerViewModel.AllCustomers.Add(CustomerViewModel.CurrentCustomer);
                    CustomerViewModel.State = 1;

                    MessageBoxResult add = MessageBox.Show("Added");
                    CustomerViewModel.CurrentCustomer = new Customer();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                    CustomerViewModel.CurrentCustomer = new Customer();
                }
            }
        }
    }
}
