using System;
using System.Web.Http;
using System.Web.Http.Results;
using NUnit.Framework;

using eu.sig.training.ch06.userservice;

namespace eu.sig.training.ch06.userservice.v2
{
    [TestFixture]
    class NotificationControllerTest
    {
        private NotificationController controller;

        [SetUp]
        public void SetUp()
        {
            NotificationController controller = new NotificationController();
        }

        [Test]
        public void TestRegister()
        {
            IHttpActionResult action = controller.Register("user@example.com", "");
            var result = action as OkNegotiatedContentResult<User>;
            Assert.AreEqual("user@example.com", result.Content.Name);
        }
    }
}
