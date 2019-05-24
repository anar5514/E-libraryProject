using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BranchCommands
{
    public class AddBranch : ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public AddBranch(BranchViewModel BranchViewModel)
        {
            this.BranchViewModel = BranchViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
