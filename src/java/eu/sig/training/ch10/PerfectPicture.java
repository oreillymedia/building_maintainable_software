package eu.sig.training.ch10;

import java.awt.Image;

import eu.sig.training.ch06.simpledigitalcamera.SimpleDigitalCamera;

public class PerfectPicture {
    public static SimpleDigitalCamera camera = null;

    // tag::takePerfectPicture[]
    public final static int DAYLIGHT_START = 6;

    public Image takePerfectPicture(int currentHour) {
        Image image;
        if (currentHour < PerfectPicture.DAYLIGHT_START) {
            camera.flashLightOn();
            image = camera.takeSnapshot();
            camera.flashLightOff();
        } else {
            image = camera.takeSnapshot();
        }
        return image;
    }
    // end::takePerfectPicture[]
}
