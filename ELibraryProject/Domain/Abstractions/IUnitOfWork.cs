using ELibraryProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        void SaveChanges();
         
        IBookRepository BookRepository { get; }
        IBranchRepository BranchRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        IUserRepository UserRepository { get; }
        IUserOnSystemRepository UserOnSystemRepository { get; }
    }
}
