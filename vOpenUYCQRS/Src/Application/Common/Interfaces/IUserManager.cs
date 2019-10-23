using System.Threading.Tasks;

namespace vOpenUYCQRS.Application.Common.Interfaces
{
    public interface IUserManager
    {
        Task<string> CreateUserAsync(string userName, string password);
    }
}
