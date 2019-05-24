using ELibraryProject.Commands.LoginPageCommands;
using ELibraryProject.Commands.MainWindowCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ELibraryProject.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public Grid Grid
        {
            get;
            set;
        }

        public MainWindowViewModel()
        {
            LogInCommand = new LogInCommand(this);
        }

        public LogInCommand LogInCommand { get; set; }

        AppExitCommand AppExitCommand => new AppExitCommand(this);
    }
}
