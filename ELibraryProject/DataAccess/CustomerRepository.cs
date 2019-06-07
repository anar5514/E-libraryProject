using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer ent)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer ent)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer ent)
        {
            throw new NotImplementedException();
        }
    }
}
