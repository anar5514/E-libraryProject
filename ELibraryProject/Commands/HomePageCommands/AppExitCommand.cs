using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class AppExitCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AppExitCommand()
        {

        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            App.Current.Shutdown();
        }
    }
}
