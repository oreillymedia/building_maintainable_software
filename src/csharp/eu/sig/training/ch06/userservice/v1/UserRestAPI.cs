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
        public string toJson(User u) {
            return "";
        }
        // tag::UserRestAPI[]

        [OperationContract]
        [WebGet(UriTemplate = "/{userId}", ResponseFormat = WebMessageFormat.Json)]
        public string getUser(string userId) {
            User user = userService.loadUser(userId);
            return toJson(user);
        }
    }
    // end::UserRestAPI[]

}