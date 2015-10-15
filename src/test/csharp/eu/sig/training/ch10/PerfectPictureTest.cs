using NUnit.Framework;
using System;
using System.Drawing;
using eu.sig.training.ch06.simpledigitalcamera;

namespace eu.sig.training.ch10 {
    
    [TestFixture]
    public class PerfectPictureTest {

        // tag::testDayPicture[]
        [Test]
        public void testDayPicture() {
            Image image = Image.FromFile("../../../../test/resources/VanGoghSunflowers.jpg");
            DigitalCameraStub cameraStub = new DigitalCameraStub();
            cameraStub.TestImage = image;
            PerfectPicture.camera = cameraStub;
            Assert.AreSame(image, new PerfectPicture().takePerfectPicture(12));
        }
        // end::testDayPicture[]

        // tag::testNightPicture[]
        [Test]
        public void testNightPicture() {
            Image image = Image.FromFile("../../../../test/resources/VanGoghStarryNight.jpg");
            DigitalCameraMock cameraMock = new DigitalCameraMock();
            cameraMock.TestImage = image;
            PerfectPicture.camera = cameraMock;
            Assert.AreSame(image, new PerfectPicture().takePerfectPicture(0));
            Assert.AreEqual(1, cameraMock.FlashOnCounter);
        }
        // end::testNightPicture[]

    }

    // tag::DigitalCameraStub[]
    class DigitalCameraStub : SimpleDigitalCamera {
        public Image TestImage;

        public Image takeSnapshot() {
            return this.TestImage;
        }

        public void flashLightOn() {
        }

        public void flashLightOff() {
        }
    }
    // end::DigitalCameraStub[]

    // tag::DigitalCameraMock[]
    class DigitalCameraMock : SimpleDigitalCamera {
        public Image TestImage;
        public int FlashOnCounter = 0;

        public Image takeSnapshot() {
            return this.TestImage;
        }

        public void flashLightOn() {
            this.FlashOnCounter++;
        }

        public void flashLightOff() {
        }
    }
    // end::DigitalCameraMock[]
}