using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
        public LoginPage()
        {
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = new CultureInfo("TR");
            Assembly a = Assembly.Load("ELibraryProject");
            ResourceManager rm = new ResourceManager("ELibraryProject.Language.Dictionary", a);
            btnLogin.Content = rm.GetString("btnLogin", ci);
            lblLang.Content = rm.GetString("lblLang", ci);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = new CultureInfo("EN");
            Assembly a = Assembly.Load("ELibraryProject");
            ResourceManager rm = new ResourceManager("ELibraryProject.Language.Dictionary", a);
            btnLogin.Content = rm.GetString("btnLogin", ci);
            lblLang.Content = rm.GetString("lblLang", ci);
        }
    }
}
