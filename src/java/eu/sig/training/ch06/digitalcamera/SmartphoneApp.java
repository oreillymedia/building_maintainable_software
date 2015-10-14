package eu.sig.training.ch06.digitalcamera;

import java.awt.Image;

@SuppressWarnings("unused")
// tag::SmartphoneApp[]
public class SmartphoneApp {
    private static DigitalCamera camera = new DigitalCamera();

    public static void main(String[] args) {
        // ...        
        Image image = camera.takeSnapshot();
        // ...
    }
}
// end::SmartphoneApp[]