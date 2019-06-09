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
        private ELibraryDbContext context;

        public void Add(Customer ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Customers.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(Customer ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.Customers.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            IEnumerable<Customer> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<Customer>(context.Customers);
                context.SaveChanges();
            }
            return list;
        }

        public Customer GetById(int id)
        {
            Customer customer;
            using (context = new ELibraryDbContext())
            {
                customer = new Customer();
                customer = context.Customers.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return customer;
        }

        public void Update(Customer ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
