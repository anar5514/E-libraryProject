using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class SaleReportRepository : ISaleReportRepository
    {
        private ELibraryDbContext context;

        public SaleReportRepository(ELibraryDbContext context)
        {
            this.context = context;
        }

        public void Add(SaleReport ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent.Customer).State = EntityState.Unchanged;
                context.Entry(ent.Book).State = EntityState.Unchanged;
                context.Entry(ent.User).State = EntityState.Unchanged;
                context.SaleReports.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(SaleReport ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.SaleReports.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<SaleReport> GetAll()
        {
            IEnumerable<SaleReport> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<SaleReport>(context.SaleReports.Include("User")
                    .Include("Book").Include("Customer"));
                context.SaveChanges();
            }
            return list;
        }

        public SaleReport GetById(int id)
        {
            SaleReport report;
            using (context = new ELibraryDbContext())
            {
                report = new SaleReport();
                report = context.SaleReports.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return report;
        }

        public void Update(SaleReport ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
