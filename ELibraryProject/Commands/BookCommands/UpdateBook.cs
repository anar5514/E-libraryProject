using ELibraryProject.DataAccess;
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
    public class UpdateBook : BaseCommand, ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateBook(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BookViewModel.AllBooks.Remove(BookViewModel.SelectedBook);
            BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
            BookViewModel.State = 3;

            UnitOfWork.BookRepository.Update(BookViewModel.CurrentBook);
            BookViewModel.CurrentBook = new Book();
        }
    }
}
