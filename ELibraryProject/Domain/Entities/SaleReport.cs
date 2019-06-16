using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Domain.Entities
{
    public class SaleReport
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime SaleDate { get; set; }
        public decimal BookSalePrice { get; set; }
        public decimal BookBuyPrice { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }


        public SaleReport Clone()
        {
            SaleReport salereport = new SaleReport();
            salereport.Id = Id;
            salereport.User = User;
            salereport.UserId = UserId;
            salereport.Customer = Customer;
            salereport.CustomerId = CustomerId;
            salereport.Book = Book;
            salereport.BookId = BookId;
            salereport.SaleDate = SaleDate;
            salereport.BookBuyPrice = BookBuyPrice;
            salereport.BookSalePrice = BookSalePrice;
            return salereport;
        }
    }
}
