using ELibraryProject.Commands.MainWindowCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        AppExitCommand AppExitCommand => new AppExitCommand(this);
    }
}
