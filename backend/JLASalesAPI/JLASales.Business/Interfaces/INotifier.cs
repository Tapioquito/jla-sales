using JLASales.Business.Notifications;

namespace JLASales.Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void HandleNotification(Notification notification);
    }
}
