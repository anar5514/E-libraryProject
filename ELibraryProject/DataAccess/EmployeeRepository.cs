using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ELibraryDbContext context;

        public void Add(Employee ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Employees.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(Employee ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.Employees.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            IEnumerable<Employee> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<Employee>(context.Employees.Include("Branch"));
                context.SaveChanges();
            }
            return list;
        }

        public Employee GetById(int id)
        {
            Employee employee;
            using (context = new ELibraryDbContext())
            {
                employee = new Employee();
                employee = context.Employees.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return employee;
        }

        public void Update(Employee ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
