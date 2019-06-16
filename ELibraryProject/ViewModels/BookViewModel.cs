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

        public BookViewModel()
        {
            CurrentBook = new Book();               
        }

    }
}
