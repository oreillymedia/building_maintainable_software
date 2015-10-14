package eu.sig.training.ch06.simpledigitalcamera;

import java.awt.Image;

@SuppressWarnings("unused")
// tag::SmartphoneApp[]
public class SmartphoneApp {
    private static SimpleDigitalCamera camera = SDK.getCamera();

    public static void main(String[] args) {
        // ...
        Image image = camera.takeSnapshot();
        // ...
    }
}
// end::SmartphoneApp[]