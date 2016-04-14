namespace eu.sig.training.ch06.userservice.v2
{

    // tag::NotificationRestAPI[]
    public class NotificationController : System.Web.Http.ApiController
    {
        private readonly UserService userService = new UserService();

        // ...

        public System.Web.Http.IHttpActionResult Register(string id,
            string notificationType)
        {
            User user = userService.LoadUser(id);
            userService.RegisterForNotifications(user,
                NotificationType.FromString(notificationType));
            return Ok();
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.ActionName("unregister")]
        public System.Web.Http.IHttpActionResult Unregister(string id,
            string notificationType)
        {
            User user = userService.LoadUser(id);
            userService.UnregisterForNotifications(user,
                NotificationType.FromString(notificationType));
            return Ok();
        }
    }
    // end::NotificationRestAPI[]
}
