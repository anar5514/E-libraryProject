﻿using ELibraryProject.ViewModels;
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
    public class ShowBooksCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

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
            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new BookView(MainWindowViewModel));
            //if (MainWindowViewModel.Grid.Children.OfType<UIElement>().FirstOrDefault(x => x is BookView) != null)
            //    MainWindowViewModel.LastOBJ.Visibility = Visibility.Visible;
            //else
            //    MainWindowViewModel.Grid.Children.Add(new BookView(MainWindowViewModel));
        }
    }
}
