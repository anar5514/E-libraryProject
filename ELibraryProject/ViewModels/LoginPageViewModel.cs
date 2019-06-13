using ELibraryProject.Commands.LoginPageCommands;
using ELibraryProject.Domain.Entities;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ELibraryProject.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
        public LogInCommand LogInCommand => new LogInCommand(this);

        public List<string> Languages { get; set; }

        private string currentLanguage;
        public string CurrentLanguage
        {
            get
            {
                return currentLanguage;
            }
            set
            {
                currentLanguage = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentLanguage)));
            }
        }

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

        public LoginPageViewModel()
        {
            UserOnSystem = new User();
        }
    }
}
