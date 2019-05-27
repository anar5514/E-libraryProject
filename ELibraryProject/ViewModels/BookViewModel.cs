using ELibraryProject.Commands.BookCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        public AddBook AddBook => new AddBook(this);
        public RemoveBook RemoveBook => new RemoveBook(this);
        public UpdateBook UpdateBook => new UpdateBook(this);

        private ObservableCollection<Book> allbooks;
        public ObservableCollection<Book> AllBooks
        {
            get
            {
                return allbooks;
            }
            set
            {
                allbooks = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllBooks)));
            }
        }

        private Book currentBook;
        public Book CurrentBook
        {
            get
            {
                return currentBook;
            }
            set
            {
                currentBook = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentBook)));
            }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {
                return selectedBook;
            }
            set
            {
                selectedBook = value;

                if (value != null)
                {
                    CurrentBook = SelectedBook.Clone();
                }
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedBook)));
            }
        }

        public ObservableCollection<Branch> Branches { get; set; }

        public int LastAddedBookID { get => allbooks.Last().Id; }

        public BookViewModel()
        {
            Branches = new ObservableCollection<Branch>()
            {           
                 new Branch()
                 {
                     Id = 0,
                     Address = "Nizami r-nu",
                     Name = "Nizami"
                 },

                 new Branch()
                 {
                     Id = 1,
                     Name = "Nerimanov",
                     Address = "Nerimanov r-nu"
                 },

                 new Branch()
                 {
                     Id = 2,
                     Name = "Sebail",
                     Address = "Sebail r-nu"
                 }
            };

            AllBooks = new ObservableCollection<Book>()
            {
                new Book()
                {
                    Name = "Sefiller",
                    AuthorName = "Viktor Huqo",
                     Branch = new Branch(){Name = "Nerimanov", Address = "Nerimanov r-nu"},
                     BuyPrice = 15,
                     SalePrice = 35,
                     PageCount = 50,
                     No = 1,
                }
            };

            CurrentBook = new Book();
        }




    }
}
