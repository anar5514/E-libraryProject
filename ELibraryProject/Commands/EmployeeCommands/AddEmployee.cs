﻿using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.EmployeeCommands
{
    public class AddEmployee : BaseCommand, ICommand
    {
        public EmployeeViewModel EmployeeViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddEmployee(EmployeeViewModel EmployeeViewModel)
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
            var zz = EmployeeViewModel.CurrentEmployee;

            if (zz.Name != null && zz.Branch != null
               && zz.Surname != null && zz.Salary != 0
               && zz.PhoneNumber != null)
            {

                UnitOfWork.EmployeeRepository.Add(EmployeeViewModel.CurrentEmployee);
                EmployeeViewModel.AllEmployees.Add(EmployeeViewModel.CurrentEmployee);
                EmployeeViewModel.State = 1;

                MessageBoxResult add = MessageBox.Show("Added");
                EmployeeViewModel.CurrentEmployee = new Employee();
            }
        }
    }
}
