package eu.sig.training.ch06.userservice.splitted;

import java.util.ArrayList;
import java.util.List;

import eu.sig.training.ch06.userservice.User;

@SuppressWarnings("unused")
// tag::UserBlockService[]
public class UserBlockService {
    public void blockUser(User user) {
        // ... 
    }

    public List<User> getAllBlockedUsers() {
        // ...
        // end::UserBlockService[]
        return new ArrayList<User>();
        // tag::UserBlockService[]
    }
}
// end::UserBlockService[]