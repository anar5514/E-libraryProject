using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class AddBook : BaseCommand, ICommand
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
            var zz = BookViewModel.CurrentBook;

            if (zz.AuthorName != null && zz.Branch != null &&
                zz.Name != null && zz.PageCount != 0 && zz.SalePrice != 0 && zz.BuyPrice != 0)
            {            
                var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);
          
                if (item == null)
                {
                    UnitOfWork = new SqlUnitOfWork();
                    UnitOfWork.BookRepository.Add(BookViewModel.CurrentBook);
                    UnitOfWork.SaveChanges();

                    BookViewModel.CurrentBook.Id = BookViewModel.LastAddedBookID + 1;
                    BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
                    BookViewModel.State = 1;

                    MessageBoxResult add = MessageBox.Show("Added");
                    BookViewModel.CurrentBook = new Book();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                    BookViewModel.CurrentBook = new Book();
                }
            }

        }
        public int MyProperty { get; set; }

    }
}
