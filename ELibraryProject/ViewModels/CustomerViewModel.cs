using ELibraryProject.Commands.CustomerCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public AddCustomer AddCustomer => new AddCustomer(this);
        public RemoveCustomer RemoveCustomer => new RemoveCustomer(this);
        public UpdateCustomer UpdateCustomer => new UpdateCustomer(this);
        public LoadCustomers LoadCustomers => new LoadCustomers(this);

        private Customer currentCustomer;
        public Customer CurrentCustomer
        {
            get
            {
                return currentCustomer;
            }
            set
            {
                currentCustomer = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentCustomer)));
            }
        }

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;     
            }
            set
            {
                State = 4;
                selectedCustomer = value;
                CurrentCustomer = SelectedCustomer.Clone();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedCustomer)));
            }
        }

        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }

        private ObservableCollection<Customer> allCustomers;
        public ObservableCollection<Customer> AllCustomers
        {
            get
            {
                return allCustomers;
            }
            set
            {
                allCustomers = value;

                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllCustomers)));
            }
        }

        public CustomerViewModel()
        {
            AllCustomers = new ObservableCollection<Customer>();
            CurrentCustomer = new Customer();
        }
    }
}
