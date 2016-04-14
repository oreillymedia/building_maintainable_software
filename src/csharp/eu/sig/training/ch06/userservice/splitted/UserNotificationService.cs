using System.Collections.Generic;

namespace eu.sig.training.ch06.userservice.splitted
{

    // tag::UserNotificationService[]
    public class UserNotificationService
    {
        public IList<NotificationType> GetNotificationTypes(User user)
        {
            // ...
            // end::UserNotificationService[]
            return new List<NotificationType>();
            // tag::UserNotificationService[]
        }

        public void Register(User user, NotificationType type)
        {
            // ...
        }

        public void Unregister(User user, NotificationType type)
        {
            // ...
        }
    }
    // end::UserNotificationService[]

}
