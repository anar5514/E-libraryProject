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

namespace ELibraryProject
{
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPageViewModel LoginPageViewModel { get; set; }

        public LoginPage()
        {
            InitializeComponent();

            this.LoginPageViewModel =new LoginPageViewModel();

            DataContext = LoginPageViewModel;
        }
    }
}
