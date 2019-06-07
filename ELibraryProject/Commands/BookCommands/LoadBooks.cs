using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class LoadBooks : BaseCommand, ICommand
    {
        public BookViewModel BookViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadBooks(BookViewModel BookViewModel)
        {
            this.BookViewModel = BookViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UnitOfWork = new SqlUnitOfWork();
            //BookViewModel.AllBooks = UnitOfWork.BookRepository.GetAll();
        }
    }
}
