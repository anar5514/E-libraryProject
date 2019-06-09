using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.BranchCommands
{
    public class LoadBranches : BaseCommand, ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadBranches(BranchViewModel BranchViewModel)
        {
            this.BranchViewModel = BranchViewModel;
            UnitOfWork = new SqlUnitOfWork();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            BranchViewModel.AllBranches = new ObservableCollection<Branch>(UnitOfWork.BranchRepository.GetAll());
        }
    }
}
