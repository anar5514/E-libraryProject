using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class BookRepository : IBookRepository
    {
        private ELibraryDbContext context;

        public BookRepository(ELibraryDbContext context)
        {
            this.context = context;
        }

        public void Add(Book ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent.Branch).State = EntityState.Unchanged;
                context.Books.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(Book ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.Books.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<Book> GetAll()
        {
            IEnumerable<Book> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<Book>(context.Books.Include("Branch"));
                context.SaveChanges();
            }
            return list;
        }

        public Book GetById(int id)
        {
            Book book;
            using (context = new ELibraryDbContext())
            {
                book = new Book();
                book = context.Books.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return book;
        }

        public void Update(Book ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
