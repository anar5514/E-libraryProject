using ELibraryProject.Commands.RentsPageCommands;
using ELibraryProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class RentViewModel : BaseViewModel
    {
        public LoadRents LoadRents => new LoadRents(this);



        private ObservableCollection<RentReport> allRentReports;
        public ObservableCollection<RentReport> AllRentReports
        {
            get
            {
                return allRentReports;
            }
            set
            {
                allRentReports = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllRentReports)));
            }
        }
    }
}
