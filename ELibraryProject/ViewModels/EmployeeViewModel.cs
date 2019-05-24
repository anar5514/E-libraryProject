using ELibraryProject.Commands.EmployeeCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class EmployeeViewModel : BaseViewModel
    {
        AddEmployee AddEmployee => new AddEmployee(this);
        RemoveEmployee RemoveEmployee => new RemoveEmployee(this);
        UpdateEmployee UpdateEmployee => new UpdateEmployee(this);

    }
}
