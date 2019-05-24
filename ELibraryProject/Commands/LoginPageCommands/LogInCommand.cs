using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.LoginPageCommands
{
    public class LogInCommand : ICommand
    {
        public LoginPageViewModel LoginPageViewModel { get; set; }

        public LogInCommand(LoginPageViewModel LoginPageViewModel)
        {
            this.LoginPageViewModel = LoginPageViewModel;           
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            (new MainWindow()).mainGrid.Children.Add(new HomePage());
        }
    }
}
