using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Permission Permissions { get; set; }

        public User Clone()
        {
            User user = new User();
            user.UserName = UserName;
            user.Password = Password;
            return user;
        }
    }
}
