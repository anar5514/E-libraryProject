using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class UpdateBook : ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public UpdateBook(BookViewModel BookViewModel)
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
            BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
            BookViewModel.State = 3;
        }
    }
}
