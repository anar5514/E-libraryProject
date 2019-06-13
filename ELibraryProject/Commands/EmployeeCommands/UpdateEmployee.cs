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
    public class UpdateEmployee : BaseCommand, ICommand
    {
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateEmployee(EmployeeViewModel EmployeeViewModel)
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
            EmployeeViewModel.AllEmployees.Remove(EmployeeViewModel.SelectedEmployee);
            EmployeeViewModel.AllEmployees.Add(EmployeeViewModel.CurrentEmployee);
            EmployeeViewModel.State = 3;

            UnitOfWork.EmployeeRepository.Update(EmployeeViewModel.CurrentEmployee);
            EmployeeViewModel.CurrentEmployee = new Employee();
        }
    }
}
