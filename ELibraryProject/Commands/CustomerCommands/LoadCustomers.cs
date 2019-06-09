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

namespace ELibraryProject.Commands.CustomerCommands
{
    public class LoadCustomers : BaseCommand, ICommand
    {
        public CustomerViewModel CustomerVIewModel { get; set; }

        public LoadCustomers(CustomerViewModel CustomerVIewModel)
        {
            this.CustomerVIewModel = CustomerVIewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {            
            CustomerVIewModel.AllCustomers = new ObservableCollection<Customer>(UnitOfWork.CustomerRepository.GetAll());
        }
    }
}
