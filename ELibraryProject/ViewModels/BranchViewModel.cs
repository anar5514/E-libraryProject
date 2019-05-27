using ELibraryProject.Commands.BranchCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class BranchViewModel : BaseViewModel
    {
        AddBranch AddBranch => new AddBranch(this);
        RemoveBranch RemoveBranch => new RemoveBranch(this);
        UpdateBranch UpdateBranch => new UpdateBranch(this);

        private List<Branch> allBranches;
        public List<Branch> AllBranches
        {
            get
            {
                return allBranches;
            }
            set
            {
                allBranches = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllBranches)));
            }
        }

        private Branch currentBranch;
        public Branch CurrentBranch
        {
            get
            {
                return currentBranch;
            }
            set
            {
                currentBranch = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentBranch)));
            }
        }



    }
}
