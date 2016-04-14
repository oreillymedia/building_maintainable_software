using System.Collections.Generic;

namespace eu.sig.training.ch06.userservice.v3
{

    // tag::UserService[]
    public class UserService
    {
        public User LoadUser(string userId)
        {
            // ...
            // end::UserService[]
            return new User();
            // tag::UserService[]
        }

        public bool DoesUserExist(string userId)
        {
            // ...
            // end::UserService[]
            return true;
            // tag::UserService[]
        }

        public User ChangeUserInfo(UserInfo userInfo)
        {
            // ...
            // end::UserService[]
            return new User();
            // tag::UserService[]
        }

        public List<NotificationType> GetNotificationTypes(User user)
        {
            // ...
            // end::UserService[]
            return new List<NotificationType>();
            // tag::UserService[]
        }

        public void RegisterForNotifications(User user, NotificationType type)
        {
            // ...
        }

        public void UnregisterForNotifications(User user, NotificationType type)
        {
            // ...
        }

        public List<User> SearchUsers(UserInfo userInfo)
        {
            // ...
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }

        public void BlockUser(User user)
        {
            // ...
        }

        public List<User> GetAllBlockedUsers()
        {
            // ...
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }
    }
    // end::UserSerice[]

}
