using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }

        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        public Employee Clone()
        {
            Employee employee = new Employee();
            employee.Name = Name;
            employee.Surname = Surname;
            employee.PhoneNumber = PhoneNumber;
            employee.Branch = Branch;
            employee.Salary = Salary;
            employee.BranchId = BranchId;
            employee.Id = Id;
            return employee;
        }
    }
}
