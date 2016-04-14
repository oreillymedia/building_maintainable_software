using System;
using System.Web.Http;
using System.Web.Http.Results;
using NUnit.Framework;

using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v1
{
    [TestFixture]
    class UserControllerTest
    {
        [Test]
        public void TestGetUserById()
        {
            UserController controller = new UserController();
            IHttpActionResult action = controller.GetUserById("user@example.com");
            var result = action as OkNegotiatedContentResult<User>;
            Assert.AreEqual("user@example.com", result.Content.Id);
        }
    }
}
