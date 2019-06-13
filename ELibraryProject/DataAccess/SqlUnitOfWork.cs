using ELibraryProject.Domain.Abstractions;


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

        public IUserOnSystemRepository UserOnSystemRepository => new UserOnSystemRepository();

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
