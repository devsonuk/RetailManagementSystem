using System.Threading.Tasks;
using RMSDesktopUI.Models;

namespace RMSDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}