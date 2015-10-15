using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v1 {

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
    }
    // end::UserSerice[]

}