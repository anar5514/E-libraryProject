using ELibraryProject.Commands.EmployeeCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class EmployeeViewModel : BaseViewModel
    {
        public AddEmployee AddEmployee => new AddEmployee(this);
        public RemoveEmployee RemoveEmployee => new RemoveEmployee(this);
        public UpdateEmployee UpdateEmployee => new UpdateEmployee(this);

        private ObservableCollection<Employee> allEmployees;
        public ObservableCollection<Employee> AllEmployees
        {
            get
            {
                return allEmployees;
            }
            set
            {
                allEmployees = value;

                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllEmployees)));
            }
        }

        private Employee currentEmployee;
        public Employee CurrentEmployee
        {
            get
            {
                return currentEmployee;
            }
            set
            {
                currentEmployee = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentEmployee)));
            }
        }

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                State = 4;
                selectedEmployee = value;
                CurrentEmployee = SelectedEmployee.Clone();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedEmployee)));

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

        public int LastAddedEmployeeID
        {
            get
            {
                if (allEmployees.Count != 0)
                    return allEmployees.Last().Id;
                else
                {
                    int result = 0;
                    return result;
                }
            }
        }

        public ObservableCollection<Branch> Branches { get; set; }

        public EmployeeViewModel()
        {
            Branches = new ObservableCollection<Branch>()
            {
                 new Branch()
                 {
                     Id = 0,
                     Address = "Nizami r-nu",
                     Name = "Nizami"
                 },

                 new Branch()
                 {
                     Id = 1,
                     Name = "Nerimanov",
                     Address = "Nerimanov r-nu"
                 },

                 new Branch()
                 {
                     Id = 2,
                     Name = "Sebail",
                     Address = "Sebail r-nu"
                 }
            };

            AllEmployees = new ObservableCollection<Employee>();

            CurrentEmployee = new Employee();
        }
    }
}
