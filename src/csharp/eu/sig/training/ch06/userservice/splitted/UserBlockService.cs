using System.Collections.Generic;
using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.splitted {

    // tag::UserBlockService[]
    public class UserBlockService {
        public void blockUser(User user) {
            // ... 
        }

        public IList<User> getAllBlockedUsers() {
            // ...
            // end::UserBlockService[]
            return new List<User>();
            // tag::UserBlockService[]
        }
    }
    // end::UserBlockService[]

}