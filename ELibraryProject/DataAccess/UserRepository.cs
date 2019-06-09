using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private ELibraryDbContext context;

        public void Add(User ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Users.Add(ent);
                context.SaveChanges();
            }
        }

        public void Delete(User ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Unchanged;
                context.Users.Remove(ent);
                context.Entry(ent).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> list;
            using (context = new ELibraryDbContext())
            {
                list = new List<User>(context.Users);
                context.SaveChanges();
            }
            return list;
        }

        public User GetById(int id)
        {
            User user;
            using (context = new ELibraryDbContext())
            {
                user = new User();
                user = context.Users.FirstOrDefault(x => x.Id == id);
                context.SaveChanges();
            }
            return user;
        }

        public bool IsExistUser(User user)
        {
            context = new ELibraryDbContext();
            if (context.Users.FirstOrDefault(x => x.UserName == user.UserName) != null)
                return true;
            return false;
        }

        public void Update(User ent)
        {
            using (context = new ELibraryDbContext())
            {
                context.Entry(ent).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
