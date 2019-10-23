using vOpenUYCQRS.Application.Common.Interfaces;
using vOpenUYCQRS.Application.Notifications.Models;
using System.Threading.Tasks;

namespace vOpenUYCQRS.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}
