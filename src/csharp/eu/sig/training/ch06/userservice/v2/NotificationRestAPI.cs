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
        public string toJson(int status) {
            return "";
        }
        // tag::NotificationRestAPI[]

        [OperationContract]
        [WebGet(UriTemplate = "/register/{userId}/{type}")]
        public void register(string userId, string notificationType) {
            User user = userService.loadUser(userId);
            userService.registerForNotifications(user, NotificationType.fromString(notificationType));
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/unregister/{userId}/{type}")]
        public void unregister(string userId, string notificationType) {
            User user = userService.loadUser(userId);
            userService.unregisterForNotifications(user, NotificationType.fromString(notificationType));
        }
    }
    // end::NotificationRestAPI[]
}