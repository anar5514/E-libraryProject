using ELibraryProject.DataAccess;
using ELibraryProject.Domain.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.SalesPageCommands
{
    public class RemoveSale : BaseCommand, ICommand
    {
        public  SaleViewModel SaleViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public RemoveSale(SaleViewModel SaleViewModel)
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
            SaleViewModel.AllSaleReports.Remove(SaleViewModel.SelectedSaleReport);
            SaleViewModel.State = 2;

            UnitOfWork.SaleReportRepository.Delete(SaleViewModel.CurrentSaleReport);
            SaleViewModel.CurrentSaleReport = new SaleReport();
        }
    }
}
