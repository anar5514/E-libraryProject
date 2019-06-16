using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BookCommands
{
    public class SaleBook : BaseCommand, ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public SaleBook(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {            
            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new SalesReportView(MainWindowViewModel));
        }
    }
}
