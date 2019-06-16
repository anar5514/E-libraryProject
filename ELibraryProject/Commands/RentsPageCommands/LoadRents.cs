using ELibraryProject.Domain.Entities;
using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.RentsPageCommands
{
    public class LoadRents : BaseCommand, ICommand
    {
        public RentViewModel RentViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoadRents(RentViewModel RentViewModel)
        {
            this.RentViewModel = RentViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //RentViewModel.A = new ObservableCollection<RentReport>(UnitOfWork.BookRepository.GetAll());

        }
    }
}
