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

namespace ELibraryProject.Commands.EmployeeCommands
{
    public class LoadEmployees : BaseCommand, ICommand
    {
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadEmployees(EmployeeViewModel EmployeeViewModel)
        {
            this.EmployeeViewModel = EmployeeViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            EmployeeViewModel.Branches = new ObservableCollection<Branch>(UnitOfWork.BranchRepository.GetAll());
            EmployeeViewModel.AllEmployees = new ObservableCollection<Employee>(UnitOfWork.EmployeeRepository.GetAll());
        }
    }
}
