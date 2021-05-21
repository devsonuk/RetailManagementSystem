using Caliburn.Micro;
using RMSDesktopUI.Helpers;
using System;
using System.Threading.Tasks;

namespace RMSDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private readonly IAPIHelper _apiHelper;

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


        public bool IsErrorVisible => (ErrorMessage?.Length > 0);

        private string _errorMessage;

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);

            }
        }



        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";
                var user = await _apiHelper.Authenticate(UserName, Password);

            }
            catch (Exception ex)
            {

                ErrorMessage = $"Invalid UserId or Password({ex.Message})";
            }

        }
    }
}
