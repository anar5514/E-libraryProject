using ELibraryProject.DataAccess;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.SalesPageCommands
{
    public class UpdateSale : BaseCommand, ICommand
    {
        public SaleViewModel SaleViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateSale(SaleViewModel SaleViewModel)
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
            throw new NotImplementedException();
        }
    }
}
