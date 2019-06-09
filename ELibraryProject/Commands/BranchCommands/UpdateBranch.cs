using ELibraryProject.DataAccess;
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
    public class UpdateBranch :BaseCommand, ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public UpdateBranch(BranchViewModel BranchViewModel)
        {
            this.BranchViewModel = BranchViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BranchViewModel.AllBranches.Remove(BranchViewModel.SelectedBranch);
            BranchViewModel.AllBranches.Add(BranchViewModel.CurrentBranch);
            BranchViewModel.State = 3;

            UnitOfWork.BranchRepository.Update(BranchViewModel.CurrentBranch);
            BranchViewModel.CurrentBranch = new Branch();
        }
    }
}
