package eu.sig.training.ch06.simpledigitalcamera;

import java.awt.Image;

// tag::DigitalCamera[]
public class DigitalCamera implements SimpleDigitalCamera {
    // ...
    // end::DigitalCamera[]
    public Image takeSnapshot() {
        return null;
    }

    public void flashLightOn() {}

    public void flashLightOff() {}
    // tag::DigitalCamera[]
}
// end::DigitalCamera[]