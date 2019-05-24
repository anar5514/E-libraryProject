using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.EmployeeCommands
{
    public class AddEmployee : ICommand
    {
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public AddEmployee(EmployeeViewModel EmployeeViewModel)
        {
            this.EmployeeViewModel = EmployeeViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
