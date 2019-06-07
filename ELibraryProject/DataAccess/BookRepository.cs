using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
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
                context.Books.Add(ent);
            }
        }

        public void Delete(Book ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Books.Remove(ent);
            }
        }

        public IQueryable<Book> GetAll()
        {
            using (context = new ELibraryDbContext())
            {
                return context.Set<Book>();
            }
        }

        public Book GetById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book ent)
        {
            context.Entry(ent).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
