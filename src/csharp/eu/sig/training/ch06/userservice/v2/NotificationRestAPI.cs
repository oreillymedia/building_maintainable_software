using System.ServiceModel;
using System.ServiceModel.Web;

using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v2 {

    // tag::NotificationRestAPI[]
    [ServiceContract]
    public class NotificationRestAPI {
        private readonly UserService userService = new UserService();

        // ...
        // end::NotificationRestAPI[]
        public string ToJson(int status) {
            return "";
        }
        // tag::NotificationRestAPI[]

        [OperationContract]
        [WebGet(UriTemplate = "/register/{userId}/{type}")]
        public void Register(string userId, string notificationType) {
            User user = userService.LoadUser(userId);
            userService.RegisterForNotifications(user, NotificationType.FromString(notificationType));
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/unregister/{userId}/{type}")]
        public void Unregister(string userId, string notificationType) {
            User user = userService.LoadUser(userId);
            userService.UnregisterForNotifications(user, NotificationType.FromString(notificationType));
        }
    }
    // end::NotificationRestAPI[]
}
