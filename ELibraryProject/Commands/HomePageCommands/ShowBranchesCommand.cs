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
    public class ShowBranchesCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public ShowBranchesCommand(MainWindowViewModel MainWindowViewModel)
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
            var HasBranchView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is BranchView) != null;
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var BranchView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is BranchView);

            if (HasBranchView)
            {
                HomePage.Visibility = Visibility.Hidden;
                BranchView.Visibility = Visibility.Visible;
            }
            else
                MainWindowViewModel.Grid.Children.Add(new BranchView(MainWindowViewModel));
        }
    }
}
