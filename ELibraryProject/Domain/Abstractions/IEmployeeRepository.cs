using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Domain.Abstractions
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
