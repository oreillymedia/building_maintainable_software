namespace eu.sig.training.ch06.userservice.v1
{

    // tag::UserRestAPI[]
    public class UserController : System.Web.Http.ApiController
    {

        private readonly UserService userService = new UserService();

        // ...

        public System.Web.Http.IHttpActionResult GetUserById(string id)
        {
            User user = userService.LoadUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
    // end::UserRestAPI[]
}
