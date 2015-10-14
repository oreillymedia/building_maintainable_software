package eu.sig.training.ch06.userservice.v2;

import java.util.ArrayList;
import java.util.List;

import eu.sig.training.ch06.userservice.NotificationType;
import eu.sig.training.ch06.userservice.User;
import eu.sig.training.ch06.userservice.UserInfo;

@SuppressWarnings("unused")
// tag::UserService[]
public class UserService {
    public User loadUser(String userId) {
        // ...
        // end::UserService[]
        return new User();
        // tag::UserService[]
    }

    public boolean doesUserExist(String userId) {
        // ...
        // end::UserService[]
        return true;
        // tag::UserService[]
    }

    public User changeUserInfo(UserInfo userInfo) {
        // ...
        // end::UserService[]
        return new User();
        // tag::UserService[]
    }

    public List<NotificationType> getNotificationTypes(User user) {
        // ...
        // end::UserService[]
        return new ArrayList<NotificationType>();
        // tag::UserService[]
    }

    public void registerForNotifications(User user, NotificationType type) {
        // ...
    }

    public void unregisterForNotifications(User user, NotificationType type) {
        // ...
    }
}
// end::UserSerice[]
