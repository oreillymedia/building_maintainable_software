using System.Collections.Generic;
using eu.sig.training.ch06;

namespace eu.sig.training.ch06.userservice.v2 {

    // tag::UserService[]
    public class UserService {
        public User loadUser(string userId) {
            // ...
            // end::UserService[]
            return new User();
            // tag::UserService[]
        }

        public bool doesUserExist(string userId) {
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
            return new List<NotificationType>();
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

}