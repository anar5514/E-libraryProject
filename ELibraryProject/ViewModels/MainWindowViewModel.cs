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
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            UserOnSystem.Password = savedPasswordHash;

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
