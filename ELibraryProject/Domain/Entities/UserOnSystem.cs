using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Domain.Entities
{
    [NotMapped]
    public class UserOnSystem
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool CanCreateBook { get; set; }
        public bool CanCreateBranch { get; set; }
        public bool CanCreateCustomer { get; set; }
        public bool CanCreateUser { get; set; }
        public bool CanRent { get; set; }
        public bool CanSale { get; set; }
    }
}
