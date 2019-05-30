using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class RemoveBook : ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public RemoveBook(BookViewModel BookViewModel)
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
            BookViewModel.AllBooks.Remove(BookViewModel.SelectedBook);
            BookViewModel.CurrentBook = new Book();
            BookViewModel.State = 2;
        }
    }
}
