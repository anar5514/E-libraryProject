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
    /// Interaction logic for BranchView.xaml
    /// </summary>
    public partial class BranchView : UserControl
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }
        private BranchViewModel branchViewModel = new BranchViewModel();

        public BranchView(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;

            InitializeComponent();

            BranchViewModel branchViewModel = new BranchViewModel();

            branchViewModel.LoadBranches.Execute(null);

            DataContext = branchViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new HomePage());
        }
    }
}
