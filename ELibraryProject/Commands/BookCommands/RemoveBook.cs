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
    public class RemoveBook : BaseCommand, ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RemoveBook(BookViewModel BookViewModel)
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
            BookViewModel.State = 2;
            
            UnitOfWork.BookRepository.Delete(BookViewModel.CurrentBook);
            BookViewModel.CurrentBook = new Book();
        }
    }
}
