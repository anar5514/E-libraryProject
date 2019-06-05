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
    /// Interaction logic for BranchView.xaml
    /// </summary>
    public partial class BranchView : UserControl
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public BranchView(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;

            InitializeComponent();

            DataContext = new BranchViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var HomePage = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is HomePage);
            var BranchView = MainWindowViewModel.Grid.Children.OfType<UIElement>()
                .FirstOrDefault(x => x is BranchView);

            BranchView.Visibility = Visibility.Hidden;
            HomePage.Visibility = Visibility.Visible;
        }
    }
}
