using System.Collections.Generic;
using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.splitted {

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

        public IList<User> searchUsers(UserInfo userInfo) {
            // ... 
            // end::UserService[]
            return new List<User>();
            // tag::UserService[]
        }
    }
    // end::UserService[]
}