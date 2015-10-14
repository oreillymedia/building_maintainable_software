package eu.sig.training.ch06.userservice.splitted;

import java.util.ArrayList;
import java.util.List;

import eu.sig.training.ch06.userservice.NotificationType;
import eu.sig.training.ch06.userservice.User;

@SuppressWarnings("unused")
// tag::UserNotificationService[]
public class UserNotificationService {
    public List<NotificationType> getNotificationTypes(User user) {
        // ...
        // end::UserNotificationService[]
        return new ArrayList<NotificationType>();
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