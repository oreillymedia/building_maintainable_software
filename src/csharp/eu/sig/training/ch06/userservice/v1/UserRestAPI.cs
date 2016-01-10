using System.ServiceModel;
using System.ServiceModel.Web;
using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v1 {

    // tag::UserRestAPI[]
    [ServiceContract]
    public class UserRestAPI {

        private readonly UserService userService = new UserService();

        // ...
        // end::UserRestAPI[]
        public string ToJson(User u) {
            return "";
        }
        // tag::UserRestAPI[]

        [OperationContract]
        [WebGet(UriTemplate = "/{userId}", ResponseFormat = WebMessageFormat.Json)]
        public string GetUser(string userId) {
            User user = userService.LoadUser(userId);
            return ToJson(user);
        }
    }
    // end::UserRestAPI[]

}
