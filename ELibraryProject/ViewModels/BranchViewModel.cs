using ELibraryProject.Commands.BranchCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class BranchViewModel : BaseViewModel
    {
        public AddBranch AddBranch => new AddBranch(this);
        public RemoveBranch RemoveBranch => new RemoveBranch(this);
        public UpdateBranch UpdateBranch => new UpdateBranch(this);
        public LoadBranches LoadBranches => new LoadBranches(this);

        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }

        private ObservableCollection<Branch> allBranches;
        public ObservableCollection<Branch> AllBranches
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

        private Branch selectedBranch;
        public Branch SelectedBranch
        {
            get
            {
                return selectedBranch;
            }
            set
            {
                selectedBranch = value;

                if (value != null)
                {
                    State = 4;
                    CurrentBranch = SelectedBranch.Clone();
                }
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedBranch)));
            }
        }

        public BranchViewModel()
        {
            AllBranches = new ObservableCollection<Branch>();

            CurrentBranch = new Branch();
        }
    }
}
