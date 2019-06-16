using ELibraryProject.DataAccess;
using ELibraryProject.Domain.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ELibraryProject.Commands.SalesPageCommands
{
    public class Sale : BaseCommand, ICommand
    {
        public SaleViewModel SaleViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public Sale(SaleViewModel SaleViewModel)
        {
            this.SaleViewModel = SaleViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var Current = SaleViewModel.CurrentSaleReport;

            if (Current.BookBuyPrice != 0 && Current.BookSalePrice != 0 &&
                Current.SaleDate != null && Current.Customer != null)
            {
                Current.Book = SaleViewModel.SelectedBook;
                Current.User = App.UserOnSystem;
                UnitOfWork.SaleReportRepository.Add(Current);
                SaleViewModel.AllSaleReports.Add(Current);
                SaleViewModel.State = 1;

                MessageBoxResult add = MessageBox.Show("Added");
                Current = new SaleReport();
            }
        }
    }
}
