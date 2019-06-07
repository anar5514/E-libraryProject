using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class ShowBooksCommand : BaseCommand, ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public int MyProperty { get; set; }

        public ShowBooksCommand(MainWindowViewModel MainWindowViewModel)
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
            var HasBookView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is BookView) != null;
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var BookView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is BookView);

            if (HasBookView)
            {
                HomePage.Visibility = Visibility.Hidden;
                BookView.Visibility = Visibility.Visible;
            }
            else
                MainWindowViewModel.Grid.Children.Add(new BookView(MainWindowViewModel));
        }
    }
}
