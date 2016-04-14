using System.Collections.Generic;

namespace eu.sig.training.ch06.userservice.splitted
{

    // tag::UserBlockService[]
    public class UserBlockService
    {
        public void BlockUser(User user)
        {
            // ...
        }

        public IList<User> GetAllBlockedUsers()
        {
            // ...
            // end::UserBlockService[]
            return new List<User>();
            // tag::UserBlockService[]
        }
    }
    // end::UserBlockService[]

}
