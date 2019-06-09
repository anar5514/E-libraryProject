using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Domain.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        bool IsExistUser (User user);
    }
}
