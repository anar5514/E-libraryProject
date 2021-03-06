﻿using ELibraryProject.Commands.UserCommands;
using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ELibraryProject.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public AddUser AddUser => new AddUser(this);
        public RemoveUser RemoveUser => new RemoveUser(this);
        public UpdateUser UpdateUser => new UpdateUser(this);
        public LoadUsers LoadUsers => new LoadUsers(this);

        private ObservableCollection<User> allUsers;
        public ObservableCollection<User> AllUsers
        {
            get
            {
                return allUsers;
            }
            set
            {
                allUsers = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllUsers)));
            }
        }

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
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }

        private User currentUser;
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentUser)));
            }
        }

        private User selectedUser;
        public User SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;

                if (value != null)
                {
                    State = 4;
                    CurrentUser = SelectedUser.Clone();
                }
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedUser)));
            }
        }

        public UserViewModel()
        {
            AllUsers = new ObservableCollection<User>();
            CurrentUser = new User();
        }
    }
}
