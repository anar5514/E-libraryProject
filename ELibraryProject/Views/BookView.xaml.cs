using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
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
        private BookViewModel bookViewModel;

        public BookView(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;

            bookViewModel = new BookViewModel();
            bookViewModel.LoadBooks.Execute(null);

            InitializeComponent();

            DataContext = bookViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel.Grid.Children.Clear();
            MainWindowViewModel.Grid.Children.Add(new HomePage());
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            if (bookViewModel.SelectedBook != null)
            {
                MainWindowViewModel.SelectedBook = new Book();
                MainWindowViewModel.SelectedBook = bookViewModel.SelectedBook;
                MainWindowViewModel.Grid.Children.Clear();
                MainWindowViewModel.Grid.Children.Add(new SalesReportView(MainWindowViewModel));
            }
        }
    }
}
