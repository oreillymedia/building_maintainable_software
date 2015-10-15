using NUnit.Framework;
using System.Drawing;
using eu.sig.training.ch06.simpledigitalcamera;
using Moq;

namespace eu.sig.training.ch10 {
    [TestFixture]
    public class PerfectPictureMoqTest {
        // tag::testNightPictureMockito[]
        [Test]
        public void testNightPictureMoq() {
            Image image =
                Image.FromFile("../../../../test/resources/VanGoghStarryNight.jpg");
            var cameraMock = new Mock<SimpleDigitalCamera>();
            cameraMock.Setup(foo => foo.takeSnapshot()).Returns(image);
            PerfectPicture.camera = cameraMock.Object;
            Assert.AreSame(image, new PerfectPicture().takePerfectPicture(0));
            cameraMock.Verify(foo => foo.flashLightOn(), Times.AtMostOnce());
        }
        // end::testNightPictureMockito[]
    }
}