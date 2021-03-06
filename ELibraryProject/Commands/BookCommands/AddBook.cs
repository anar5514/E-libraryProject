﻿using ELibraryProject.DataAccess;
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
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var zz = BookViewModel.CurrentBook;

            if (zz.Author!= null && zz.Branch != null &&
                zz.Name != null && zz.PageCount != 0 && zz.SalePrice != 0 
                && zz.BuyPrice != 0)
            {               
                UnitOfWork.BookRepository.Add(BookViewModel.CurrentBook);
                BookViewModel.AllBooks.Add(BookViewModel.CurrentBook);
                BookViewModel.State = 1;

                MessageBoxResult add = MessageBox.Show("Added");
                BookViewModel.CurrentBook = new Book();
            }

        }

    }
}
