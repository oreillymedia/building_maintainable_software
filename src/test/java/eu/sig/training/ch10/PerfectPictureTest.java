package eu.sig.training.ch10;

import static org.junit.Assert.assertEquals;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;

import org.junit.Test;

import eu.sig.training.ch06.simpledigitalcamera.SimpleDigitalCamera;
import eu.sig.training.ch10.PerfectPicture;

public class PerfectPictureTest {

    // tag::testDayPicture[]
    @Test
    public void testDayPicture() throws IOException {
        BufferedImage image =
            ImageIO.read(new File("src/test/resources/VanGoghSunflowers.jpg"));
        DigitalCameraStub cameraStub = new DigitalCameraStub();
        cameraStub.testImage = image;
        PerfectPicture.camera = cameraStub;
        assertEquals(image, new PerfectPicture().takePerfectPicture(12));
    }
    // end::testDayPicture[]

    // tag::testNightPicture[]
    @Test
    public void testNightPicture() throws IOException {
        BufferedImage image =
            ImageIO.read(new File("src/test/resources/VanGoghStarryNight.jpg"));
        DigitalCameraMock cameraMock = new DigitalCameraMock();
        cameraMock.testImage = image;
        PerfectPicture.camera = cameraMock;
        assertEquals(image, new PerfectPicture().takePerfectPicture(0));
        assertEquals(1, cameraMock.flashOnCounter);
    }
    // end::testNightPicture[]

}

// tag::DigitalCameraStub[]
class DigitalCameraStub implements SimpleDigitalCamera {
    public Image testImage;

    public Image takeSnapshot() {
        return this.testImage;
    }

    public void flashLightOn() {}

    public void flashLightOff() {}
}
// end::DigitalCameraStub[]

// tag::DigitalCameraMock[]
class DigitalCameraMock implements SimpleDigitalCamera {
    public Image testImage;
    public int flashOnCounter = 0;

    public Image takeSnapshot() {
        return this.testImage;
    }

    public void flashLightOn() {
        this.flashOnCounter++;
    }

    public void flashLightOff() {}
}
// end::DigitalCameraMock[]
