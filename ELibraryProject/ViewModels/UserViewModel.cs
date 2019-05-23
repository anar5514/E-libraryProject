using ELibraryProject.Commands.UserCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public AddUser AddUser => new AddUser(this);
        public RemoveUser RemoveUser => new RemoveUser(this);
        public UpdateUser UpdateUser => new UpdateUser(this);


        public UserViewModel()
        {
            
        }
    }
}
