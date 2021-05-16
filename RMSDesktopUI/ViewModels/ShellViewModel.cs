using Caliburn.Micro;

namespace RMSDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel _loginVm;

        public ShellViewModel(LoginViewModel loginVm)
        {
            _loginVm = loginVm;
            ActivateItemAsync(_loginVm);
        }
    }
}
