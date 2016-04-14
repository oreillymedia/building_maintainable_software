using NUnit.Framework;
using System.Drawing;
using eu.sig.training.ch06.simpledigitalcamera;
using Moq;

namespace eu.sig.training.ch10
{
    [TestFixture]
    public class PerfectPictureMoqTest
    {
        // tag::testNightPictureMockito[]
        [Test]
        public void TestNightPictureMoq()
        {
            Image image =
                Image.FromFile("../../../../test/resources/VanGoghStarryNight.jpg");
            var cameraMock = new Mock<ISimpleDigitalCamera>();
            cameraMock.Setup(foo => foo.TakeSnapshot()).Returns(image);
            PerfectPicture.camera = cameraMock.Object;
            Assert.AreSame(image, new PerfectPicture().TakePerfectPicture(0));
            cameraMock.Verify(foo => foo.FlashLightOn(), Times.AtMostOnce());
        }
        // end::testNightPictureMockito[]
    }
}
