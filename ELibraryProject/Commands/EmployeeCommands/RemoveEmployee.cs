using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.EmployeeCommands
{
    public class RemoveEmployee :BaseCommand, ICommand
    {
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public RemoveEmployee(EmployeeViewModel EmployeeViewModel)
        {
            this.EmployeeViewModel = EmployeeViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            EmployeeViewModel.AllEmployees.Remove(EmployeeViewModel.SelectedEmployee);
            EmployeeViewModel.State = 2;

            UnitOfWork.EmployeeRepository.Delete(EmployeeViewModel.CurrentEmployee);
            EmployeeViewModel.CurrentEmployee = new Employee();
        }
    }
}
