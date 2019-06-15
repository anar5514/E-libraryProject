using ELibraryProject.Domain.Abstractions;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.DataAccess
{
    public class UserOnSystemRepository : IUserOnSystemRepository
    {
        ELibraryDbContext context;

        public User GetUser(User user)
        {
            using (context = new ELibraryDbContext())
            {
                return context.Users.FirstOrDefault
                    (x => x.UserName == user.UserName && x.Password == user.Password);
            }
        }
    }
}
