using System.Collections.Generic;
using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v3 {

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

        public List<User> searchUsers(UserInfo userInfo) {
            // ...
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }

        public void blockUser(User user) {
            // ... 
        }

        public List<User> getAllBlockedUsers() {
            // ...
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }
    }
    // end::UserSerice[]

}