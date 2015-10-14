package eu.sig.training.ch06.advanceddigitalcamera;

import java.awt.Image;
import java.awt.image.BufferedImage;

@SuppressWarnings("unused")
// tag::DigitalCamera[]
public class DigitalCamera {
    public Image takeSnapshot() {
        // ...
        // end::DigitalCamera[]
        return new BufferedImage(1920, 1080, BufferedImage.TYPE_INT_ARGB);
        // tag::DigitalCamera[]
    }

    public void flashLightOn() {
        // ... 
    }

    public void flaslLightOff() {
        // ... 
    }

    public Image takePanoramaSnapshot() {
        // end::DigitalCamera[]
        return new BufferedImage(1920, 1080, BufferedImage.TYPE_INT_ARGB);
        // tag::DigitalCamera[]
        // ... 
    }

    public Video record() {
        // ...
        // end::DigitalCamera[]
        return new Video();
        // tag::DigitalCamera[]
    }

    public void setTimer(int seconds) {
        // ... 
    }

    public void zoomIn() {
        // ...
    }

    public void zoomOut() {
        // ... 
    }
}
// end::DigitalCamera[]