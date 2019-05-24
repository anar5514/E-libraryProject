using ELibraryProject.Commands.LoginPageCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class LoginPageViewModel
    {
        LogInCommand LogInCommand => new LogInCommand(this);


        
    }
}
