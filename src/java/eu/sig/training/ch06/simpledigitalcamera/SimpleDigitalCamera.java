package eu.sig.training.ch06.simpledigitalcamera;

import java.awt.Image;

// tag::SimpleDigitalCamera[]
public interface SimpleDigitalCamera {
    Image takeSnapshot();

    void flashLightOn();

    void flashLightOff();
}
// end::SimpleDigitalCamera[]
