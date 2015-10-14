package eu.sig.training.ch06.userservice.v1;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.Response;

import eu.sig.training.ch06.userservice.User;

// tag::UserRestAPI[]
// The @Path and @GET attributes are defined by the the Java REST Service API
@Path("/user")
public class UserRestAPI {

    private final UserService userService = new UserService();

    // ...
    // end::UserRestAPI[]
    public Response toJson(@SuppressWarnings("unused") User u) {
        return Response.accepted().build();
    }
    // tag::UserRestAPI[]

    @GET
    @Path("/{userId}")
    public Response getUser(@PathParam(value = "userId") String userId) {
        User user = userService.loadUser(userId);
        return toJson(user);
    }
}
// end::UserRestAPI[]