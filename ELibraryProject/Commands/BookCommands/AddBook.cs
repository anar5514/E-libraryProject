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
            var zz = BookViewModel.CurrentBook;
            if (zz.AuthorName != null && zz.Branch != null &&
                zz.Name != null && zz.PageCount != 0 && zz.SalePrice != 0 && zz.BuyPrice != 0)
            {
                var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);

                if (BookViewModel.AllBooks.Count != 0)
                {
                    int index = BookViewModel.AllBooks.Count - 1;
                    int newID = BookViewModel.AllBooks[index].Id + 1;
                    BookViewModel.CurrentBook.Id = newID;
                }
                if (item == null)
                {

                    BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);

                    MessageBoxResult add = MessageBox.Show("Added");
                    BookViewModel.CurrentBook = new Book();
                    BookViewModel.SelectedBook = new Book();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                }
            }

            BookViewModel.CurrentBook.No = BookViewModel.AllBooks.Last().Id + 1;
            BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
            BookViewModel.CurrentBook = new Book();
        }


    }
}
