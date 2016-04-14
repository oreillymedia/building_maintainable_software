package eu.sig.training.ch10;

import static org.junit.Assert.assertEquals;
import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.when;

import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;

import org.junit.Test;

import eu.sig.training.ch06.simpledigitalcamera.SimpleDigitalCamera;
import eu.sig.training.ch10.PerfectPicture;

public class PerfectPictureMockTest {
    // tag::testNightPictureMockito[]
    @Test
    public void testNightPictureMockito() throws IOException {
        BufferedImage image =
            ImageIO.read(new File("src/test/resources/VanGoghStarryNight.jpg"));
        SimpleDigitalCamera cameraMock = mock(SimpleDigitalCamera.class);
        PerfectPicture.camera = cameraMock;
        when(cameraMock.takeSnapshot()).thenReturn(image);
        assertEquals(image, new PerfectPicture().takePerfectPicture(0));
        verify(cameraMock).flashLightOn();
    }
    // end::testNightPictureMockito[]
}
