using RMSDesktopUI.Models;
using System.Threading.Tasks;

namespace RMSDesktopUILibrary.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}