package eu.sig.training.ch06.userservice.splitted;

import java.util.ArrayList;
import java.util.List;

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

    public List<User> searchUsers(UserInfo userInfo) {
        // ... 
        // end::UserService[]
        return new ArrayList<User>();
        // tag::UserService[]
    }
}
// end::UserService[]