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
        public double BuyPrice { get; set; }
        public double SalePrice{ get; set; }
        public int PageCount { get; set; }
        public Branch Branch { get; set; }

        public Book Clone()
        {
            Book newbook = new Book();
            newbook.AuthorName = this.AuthorName;
            newbook.Branch = this.Branch;
            newbook.Name = this.Name;
            newbook.No = this.No;
            newbook.PageCount = this.PageCount;
            newbook.BuyPrice = this.BuyPrice;
            newbook.SalePrice = this.SalePrice;
            return newbook;
        }
    }
}
