using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class BranchRepository : IBranchRepository
    {
        private ELibraryDbContext context;

        public void Add(Branch ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Branches.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(Branch ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.Branches.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<Branch> GetAll()
        {
            IEnumerable<Branch> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<Branch>(context.Branches);
                context.SaveChanges();
            }
            return list;
        }

        public Branch GetById(int id)
        {
            Branch branch;
            using (context = new ELibraryDbContext())
            {
                branch = new Branch();
                branch = context.Branches.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return branch;
        }

        public void Update(Branch ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
