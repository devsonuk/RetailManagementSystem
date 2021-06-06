using RMSDesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RMSDesktopUILibrary.Api
{
    public interface IApiHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}