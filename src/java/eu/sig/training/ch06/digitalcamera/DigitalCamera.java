package eu.sig.training.ch06.digitalcamera;

import java.awt.Image;
import java.awt.image.BufferedImage;

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
}
// end::DigitalCamera[]