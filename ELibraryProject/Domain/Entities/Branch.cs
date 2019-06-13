using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Branch Clone()
        {
            Branch branch = new Branch();
            branch.Id = Id;
            branch.Name = Name;
            branch.Address = Address;
            return branch;
        }

        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
