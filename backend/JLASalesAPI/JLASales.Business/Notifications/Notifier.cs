using JLASales.Business.Interfaces;

namespace JLASales.Business.Notifications
{
    public class Notifier : INotifier
    {
        public Notifier()
        {
            _notifications = new List<Notification>();
        }
        private List<Notification> _notifications;
        public List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void HandleNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotification()
        {
          return  _notifications.Any();
        }
    }
}
