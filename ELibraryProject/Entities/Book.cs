using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int BuyPrice { get; set; }
        public int SalePrice{ get; set; }
        public int Count { get; set; }
        public Branch Branch { get; set; }
    }
}
