using Ombe.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ombe.Business.Notifications
{
    public class Notifier : INotifier
    {
        private List<Notification> _notifications;

        public Notifier()
        {
            _notifications = new List<Notification>();
        }

        public List<Notification> getNotification()
        {
            return _notifications;
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool hasNotification()
        {
            return _notifications.Any();
        }
    }
}
