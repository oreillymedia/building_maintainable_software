package eu.sig.training.ch06.userservice.v1;

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
}
// end::UserSerice[]
