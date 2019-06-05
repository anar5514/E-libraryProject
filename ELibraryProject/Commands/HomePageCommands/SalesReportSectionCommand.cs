using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class SalesReportSectionCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public SalesReportSectionCommand(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //var HasSalesView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
            //    .FirstOrDefault(x => x is Sale) != null;
            //var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
            //    .FirstOrDefault(x => x is HomePage);
            //var BookView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
            //    .FirstOrDefault(x => x is BookView);

            //if (HasBookView)
            //{
            //    HomePage.Visibility = Visibility.Hidden;
            //    BookView.Visibility = Visibility.Visible;
            //}
            //else
            //    MainWindowViewModel.Grid.Children.Add(new BookView(MainWindowViewModel));
        }
    }
}
