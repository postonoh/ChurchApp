﻿using ChurchApp.Common;
using ChurchApp.Services;
using ChurchApp.Views.AppShell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WordPressPCL.Models;
using Xamarin.Auth;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ChurchApp.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private readonly WordpressService _wordPressService;

        private bool _isLoggingIn;
        public bool IsLoggingIn
        {
            get => _isLoggingIn;
            set { _isLoggingIn = value; OnPropertyChanged(); LoginCommand.ChangeCanExecute(); }
        }

        private bool _isAuthenticated;
        public bool IsAuthenticated
        {
            get => _isAuthenticated;
            set { _isAuthenticated = value; OnPropertyChanged(); }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set { _userName = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }


        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set { _currentUser = value; OnPropertyChanged(); }
        }


        public SettingsViewModel(WordpressService wordpressService)
        {
            _wordPressService = wordpressService;
        }

        public SettingsViewModel()
        {
            
        }


        private AsyncRelayCommand _tryAutoLoginCommand;
        public AsyncRelayCommand TryAutoLoginCommand => _tryAutoLoginCommand ?? (_tryAutoLoginCommand = new AsyncRelayCommand(TryAutoLogin));

        private Command _loginCommand;
        public Command LoginCommand => _loginCommand ?? (_loginCommand = new Command(Login, CanLogin));

        private bool CanLogin()
        {
            return !IsLoggingIn;
        }

        private ICommand _logoutCommand;
        public ICommand LogoutCommand => _logoutCommand ?? (_logoutCommand = new Command(Logout));



        public async Task TryAutoLogin()
        {

            var data = (await AccountStore.Create().FindAccountsForServiceAsync("wordpress")).FirstOrDefault();

            if (data == null)
                return;

            var userName = data.Username;
            var password = data.Properties["password"];

            var user = await _wordPressService.LoginAsync(userName, password);
            if (user != null)
            {
                CurrentUser = user;
                IsLoggingIn = true;
            }
        }
         
        public async void Login()
        {          

            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                var user = await _wordPressService.LoginAsync(UserName, Password);
                if (user != null)
                {
                    // Store username & JWT token for logging in on next app launch
                    await AccountStore.Create().SaveAsync(new Account(UserName, new Dictionary<string, string> { { "password", Password } }), "wordpress");
                    CurrentUser = user;
                    IsLoggingIn = true;
                    Application.Current.MainPage = new AppShellPage();
                }
                else
                {
                    IsLoggingIn = false;
                }
                IsLoggingIn = false;
            }

        }

        public async void Logout()
        {
            _wordPressService.Logout();
            CurrentUser = null;

            var data = (await AccountStore.Create().FindAccountsForServiceAsync("wordpress")).FirstOrDefault();

            if (data == null)
                return;

            await AccountStore.Create().DeleteAsync(data, "wordpress");
        }

    }
}
