using ELibraryProject.Commands.BookCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class BookViewModel : BaseViewModel
    {
        public AddBook AddBook => new AddBook(this);
        public RemoveBook RemoveBook => new RemoveBook(this);
        public UpdateBook UpdateBook => new UpdateBook(this);

        public BookViewModel()
        {

        }

        private List<Branch> branches;
        public List<Branch> Branches
        {
            get
            {
                return Branches;
            }

            set
            {
                Branches = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Branches)));
            }
        }


        private Branch currentBranch;
        public Branch CurrentBranch
        {
            get
            {
                return CurrentBranch;
            }

            set
            {
                CurrentBranch = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentBranch)));
            }
        }

    }
}
