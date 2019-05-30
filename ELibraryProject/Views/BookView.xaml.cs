﻿using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ELibraryProject.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public BookView(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;

            BookViewModel bookViewModel = new BookViewModel();
            InitializeComponent();
            DataContext = bookViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainWindowViewModel.Grid.Children.Cast<UIElement>().Last().Visibility = Visibility.Hidden;
            MainWindowViewModel.LastOBJ.Visibility = Visibility.Hidden;
            MainWindowViewModel.Grid.Children.Add(new HomePage());
        }
    }
}
