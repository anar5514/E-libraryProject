using ELibraryProject.Commands.BranchCommands;
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
    }
}
