using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.UserCommands
{
    public class AddUser : BaseCommand, ICommand
    {
        public UserViewModel UserViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddUser(UserViewModel UserViewModel)
        {
            this.UserViewModel = UserViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var user = UserViewModel.CurrentUser;
            
            user.Password = (parameter as PasswordBox).Password;

            if (user.UserName != null && user.Password != null)
            {
                #region Old Code
                //var item = BookViewModel.AllBooks.FirstOrDefault(x => x.Id == BookViewModel.CurrentBook.Id);

                //if (item == null)
                //{
                //    BookViewModel.CurrentBook.BranchId = BookViewModel.CurrentBook.Branch.Id;
                //    UnitOfWork.BookRepository.Add(BookViewModel.CurrentBook);
                //    BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
                //    BookViewModel.State = 1;

                //    MessageBoxResult add = MessageBox.Show("Added");
                //    BookViewModel.CurrentBook = new Book();
                //}
                //else
                //{
                //    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                //    BookViewModel.CurrentBook = new Book();
                //}
                #endregion

                UnitOfWork.UserRepository.Add(UserViewModel.CurrentUser);
                UserViewModel.AllUsers.Add(UserViewModel.CurrentUser);
                UserViewModel.State = 1;

                MessageBoxResult add = MessageBox.Show("Added");
                UserViewModel.CurrentUser = new User();
            }
        }
    }
}
