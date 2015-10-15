using System.Collections.Generic;
using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.splitted {

    // tag::UserNotificationService[]
    public class UserNotificationService {
        public IList<NotificationType> getNotificationTypes(User user) {
            // ...
            // end::UserNotificationService[]
            return new List<NotificationType>();
            // tag::UserNotificationService[]
        }

        public void register(User user, NotificationType type) {
            // ...  
        }

        public void unregister(User user, NotificationType type) {
            // ...  
        }
    }
    // end::UserNotificationService[]

}