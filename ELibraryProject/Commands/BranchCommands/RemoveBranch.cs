﻿using ELibraryProject.DataAccess;
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
    public class RemoveBranch : BaseCommand, ICommand
    {
        public BranchViewModel BranchViewModel { get; set; }

        public RemoveBranch(BranchViewModel BranchViewModel)
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
            BranchViewModel.State = 2;

            UnitOfWork.BranchRepository.Delete(BranchViewModel.CurrentBranch);
            BranchViewModel.CurrentBranch = new Branch();
        }
    }
}
