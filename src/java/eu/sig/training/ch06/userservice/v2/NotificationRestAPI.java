package eu.sig.training.ch06.userservice.v2;

import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.Response;

import org.apache.http.HttpStatus;

import eu.sig.training.ch06.userservice.NotificationType;
import eu.sig.training.ch06.userservice.User;

// tag::NotificationRestAPI[]
@Path("/notification")
public class NotificationRestAPI {
    private final UserService userService = new UserService();

    // ...
    // end::NotificationRestAPI[]
    public Response toJson(@SuppressWarnings("unused") int status) {
        return Response.accepted().build();
    }
    // tag::NotificationRestAPI[]

    @POST
    @Path("/register/{userId}/{type}")
    public Response register(@PathParam(value = "userId") String userId,
        @PathParam(value = "type") String notificationType) {
        User user = userService.loadUser(userId);
        userService.registerForNotifications(user, NotificationType.fromString(notificationType));
        return toJson(HttpStatus.SC_OK);
    }

    @POST
    @Path("/unregister/{userId}/{type}")
    public Response unregister(@PathParam(value = "userId") String userId,
        @PathParam(value = "type") String notificationType) {
        User user = userService.loadUser(userId);
        userService.unregisterForNotifications(user, NotificationType.fromString(notificationType));
        return toJson(HttpStatus.SC_OK);
    }
}
// end::NotificationRestAPI[]