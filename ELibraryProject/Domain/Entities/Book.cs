using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double BuyPrice { get; set; }
        public double SalePrice{ get; set; }
        public int PageCount { get; set; }

  
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        public Book Clone()
        {
            Book newbook = new Book();
            newbook.Author = this.Author;
            newbook.Branch = this.Branch;
            newbook.Name = this.Name;
            newbook.PageCount = this.PageCount;
            newbook.BuyPrice = this.BuyPrice;
            newbook.SalePrice = this.SalePrice;
            newbook.BranchId = BranchId;
            newbook.Id = Id;
            return newbook;
        }
    }
}
