using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public bool CanCreateBook { get; set; } = true;
        public bool CanCreateBranch { get; set; } = true;
        public bool CanCreateCustomer { get; set; } = true;
        public bool CanCreateEmployee { get; set; } = true;
        public bool CanCreateUser{ get; set; } = true;
        public bool CanRent { get; set; } = true;
        public bool CanSale { get; set; } = true;

        public User Clone()
        {
            User user = new User();
            user.UserName = UserName;
            user.Password = Password;
            user.CanCreateBook = CanCreateBook;
            user.CanCreateBranch = CanCreateBranch;
            user.CanCreateCustomer = CanCreateCustomer;
            user.CanCreateUser = CanCreateUser;
            user.CanRent = CanRent;
            user.CanCreateEmployee = CanCreateEmployee;
            user.CanSale = CanSale;
            return user;
        }
    }
}
