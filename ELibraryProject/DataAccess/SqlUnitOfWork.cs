using ELibraryProject.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    class SqlUnitOfWork : IUnitOfWork
    {
        private ELibraryDbContext context;

        public IBookRepository BookRepository => new BookRepository(context);

        public IBranchRepository BranchRepository => new BranchRepository();

        public ICustomerRepository CustomerRepository => new CustomerRepository();

        public IEmployeeRepository EmployeeRepository => new EmployeeRepository();

        public IPermissionRepository PermissionRepository => new PermissionRepository();

        public IUserRepository UserRepository => new UserRepository();

        public void SaveChanges()
        {
            context = new ELibraryDbContext();
            context.SaveChanges();
        }
    }
}
