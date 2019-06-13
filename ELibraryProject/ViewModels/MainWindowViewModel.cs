using ELibraryProject.Commands.BookCommands;
using ELibraryProject.Commands.HomePageCommands;
using ELibraryProject.Commands.LoginPageCommands;
using ELibraryProject.Commands.MainWindowCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ELibraryProject.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private User userOnSystem;
        public User UserOnSystem
        {
            get
            {
                return userOnSystem;
            }
            set
            {
                userOnSystem = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(UserOnSystem)));
            }
        }

        public User UserWithHashedPassword(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);
            var asci = new ASCIIEncoding();
            var result = asci.GetString(sha1data);
            
            UserOnSystem.Password = result;

            return UserOnSystem;
        }

        public Grid Grid { get; set; }

        public LogInCommand LogInCommand => new LogInCommand(this);

        public ShowBooksCommand ShowBooksCommand => new ShowBooksCommand(this);

        public ShowBranchesCommand ShowBranchesCommand => new ShowBranchesCommand(this);

        public ShowCustomersCommand ShowCustomersCommand => new ShowCustomersCommand(this);

        public ShowUsersCommand ShowUsersCommand => new ShowUsersCommand(this);

        public ShowEmployeesCommand ShowEmployeesCommand => new ShowEmployeesCommand(this);

        public RentalReportSectionCommand RentalReportSectionCommand => new RentalReportSectionCommand(this);

        public SalesReportSectionCommand SalesReportSectionCommand => new SalesReportSectionCommand(this);

        public AppExitCommand AppExitCommand => new AppExitCommand(this);

        public LogOutCommand LogOutCommand => new LogOutCommand(this);

        public MainWindowViewModel()
        {
            UserOnSystem = new User();
        }

    }
}
