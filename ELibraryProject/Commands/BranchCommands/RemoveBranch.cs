using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BranchCommands
{
    public class RemoveBranch : ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public RemoveBranch(BranchViewModel BranchViewModel)
        {
            this.BranchViewModel = BranchViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BranchViewModel.State = 2;
            BranchViewModel.AllBranches.Remove(BranchViewModel.SelectedBranch);
            BranchViewModel.CurrentBranch = new Branch();
        }
    }
}
