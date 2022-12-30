using Ombe.Business.Notifications;
using System.Collections.Generic;

namespace Ombe.Business.Interfaces
{
    public interface INotifier
    {
        bool hasNotification();
        List<Notification> getNotification();
        void Handle(Notification notification);
    }
}
