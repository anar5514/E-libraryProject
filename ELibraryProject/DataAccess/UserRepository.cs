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
            throw new NotImplementedException();
        }

        public void Delete(User ent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
