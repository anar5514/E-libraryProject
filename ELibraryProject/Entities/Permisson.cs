using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public enum Permisson
    {
        //public int Id { get; set; }
        //public int No { get; set; }
        //public bool CanCreateBook{ get; set; }
        //public bool CanCreateUser{ get; set; }
        //public bool CanCreateBranch { get; set; }
        //public bool CanCreateCustomer { get; set; }
        //public bool CanRent { get; set; }

        CanCreateBook = 0,
        CanCreateUser,
        CanCreateBranch,
        CanCreateCustomer,
        CanRent

        //public void Add()
        //{
        //    List<enum> a = new List<enum>(); 
        //}
    }


    public class A
    {
        public void WOW()
        {
            List<Permisson> permissons = new List<Permisson>();
        }
    }


}
