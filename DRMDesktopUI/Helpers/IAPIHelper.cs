using DRMDesktopUI.Models;
using System.Threading.Tasks;

namespace DRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}