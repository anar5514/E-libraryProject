using ELibraryProject.Commands.CustomerCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public AddCustomer AddCustomer => new AddCustomer(this);
        public RemoveCustomer RemoveCustomer => new RemoveCustomer(this);
        public UpdateCustomer UpdateCustomer => new UpdateCustomer(this);

    }
}
