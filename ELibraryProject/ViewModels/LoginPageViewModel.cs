using ELibraryProject.Commands.LoginPageCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ELibraryProject.ViewModels
{
    public class LoginPageViewModel:BaseViewModel
    {
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
    }
}
