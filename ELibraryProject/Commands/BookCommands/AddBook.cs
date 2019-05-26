using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class AddBook : ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public AddBook(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BookViewModel.CurrentBook.No = BookViewModel.AllBooks.Last().Id;
            BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
        }

    }
}
