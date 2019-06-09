using ELibraryProject.DataAccess;
using ELibraryProject.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ELibraryProject.Commands.BranchCommands
{
    public class AddBranch : BaseCommand, ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public AddBranch(BranchViewModel BranchViewModel)
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
            var zz = BranchViewModel.CurrentBranch;

            if (zz.Name != null && zz.Address != null )
            {

                var item = BranchViewModel.AllBranches.FirstOrDefault(x => x.Id == BranchViewModel.CurrentBranch.Id);

                if (item == null)
                {
                    UnitOfWork.BranchRepository.Add(BranchViewModel.CurrentBranch);
                    BranchViewModel.AllBranches.Add(BranchViewModel.CurrentBranch);
                    BranchViewModel.State = 1;

                    MessageBoxResult add = MessageBox.Show("Added");
                    BranchViewModel.CurrentBranch = new Branch();

                }
                else
                {
                    MessageBoxResult add = MessageBox.Show("Can not add this item, you can only update and delete");
                    BranchViewModel.CurrentBranch = new Branch();
                }
            }
        }
    }
}
