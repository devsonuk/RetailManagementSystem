﻿using Caliburn.Micro;
using RMSDesktopUI.Helpers;
using System;
using System.Threading.Tasks;

namespace RMSDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);

            }
        }


        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }


        public bool CanLogIn => (UserName?.Length > 0 && Password?.Length > 0);

        //public bool CanLogIn
        //{
        //    get
        //    {
        //        return (UserName?.Length > 0 && Password?.Length > 0);
        //    }
        //}

        public async Task LogIn()
        {
            try
            {
                var user = await _apiHelper.Authenticate(UserName, Password);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
