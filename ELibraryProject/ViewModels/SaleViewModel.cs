using ELibraryProject.Commands.SalesPageCommands;
using ELibraryProject.Domain.Entities;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.ViewModels
{
    public class SaleViewModel : BaseViewModel
    {
        public LoadSales LoadSales => new LoadSales(this);
        public Sale Sale => new Sale(this);
        public RemoveSale RemoveSale => new RemoveSale(this);
        public UpdateSale UpdateSale => new UpdateSale(this);

        public Book SelectedBook;

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
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(State)));  
            }
        }

        private SaleReport selectedSaleReport;
        public SaleReport SelectedSaleReport
        {
            get
            {
                return selectedSaleReport;
            }
            set
            {
                selectedSaleReport = value;

                if (value != null)
                {
                    State = 4;
                    CurrentSaleReport = SelectedSaleReport.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedSaleReport)));
            }
        }

        private SaleReport currentSaleReport;
        public SaleReport CurrentSaleReport
        {
            get
            {
                return currentSaleReport;
            }
            set
            {
                currentSaleReport = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentSaleReport)));
            }
        }

        private ObservableCollection<SaleReport> allSaleReprts;
        public ObservableCollection<SaleReport> AllSaleReports
        {
            get
            {
                return allSaleReprts;
            }
            set
            {
                allSaleReprts = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllSaleReports)));
            }
        }

        public ObservableCollection<Customer> AllCustomers { get; set; }

        private MainWindowViewModel m;

        public SaleViewModel(MainWindowViewModel m)
        {
            CurrentSaleReport = new SaleReport();
        }
    }
}
