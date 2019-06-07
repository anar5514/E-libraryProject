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
        public LoadBooks LoadBooks => new LoadBooks(this);

        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }

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
                    State = 4;
                    CurrentBook = SelectedBook.Clone();
                }
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedBook)));
            }
        }

        public ObservableCollection<Branch> Branches { get; set; }

        public int LastAddedBookID
        {
            get
            {
                if (allbooks.Count != 0)
                    return AllBooks.Last().Id;
                else
                {
                    int result = 0;
                    return result;
                }
            }
        }

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

            AllBooks = new ObservableCollection<Book>();

            CurrentBook = new Book();


                 
        }

    }
}
