using System.Collections.Generic;

namespace eu.sig.training.ch06.userservice.splitted
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

        public IList<User> SearchUsers(UserInfo userInfo)
        {
            // ...
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }
    }
    // end::UserService[]
}
