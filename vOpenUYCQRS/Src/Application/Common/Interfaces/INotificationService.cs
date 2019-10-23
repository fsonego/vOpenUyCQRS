using vOpenUYCQRS.Application.Notifications.Models;
using System.Threading.Tasks;

namespace vOpenUYCQRS.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
    }
}
