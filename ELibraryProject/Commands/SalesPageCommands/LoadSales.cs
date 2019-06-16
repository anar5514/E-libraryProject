using ELibraryProject.DataAccess;
using ELibraryProject.Domain.Entities;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.SalesPageCommands
{
    public class LoadSales : BaseCommand, ICommand
    {
        public SaleViewModel SaleViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadSales(SaleViewModel SaleViewModel)
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
            SaleViewModel.SelectedBook = parameter as Book;
            SaleViewModel.AllCustomers = new ObservableCollection<Customer>(UnitOfWork.CustomerRepository.GetAll());
            SaleViewModel.AllSaleReports = new ObservableCollection<SaleReport>(UnitOfWork.SaleReportRepository.GetAll());
        }
    }
}
