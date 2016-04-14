namespace eu.sig.training.ch06.userservice.v1
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
    }
    // end::UserSerice[]
}
