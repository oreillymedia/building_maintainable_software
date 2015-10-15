using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera {

    // tag::SmartphoneApp[]
    public class SmartphoneApp {
        private static SimpleDigitalCamera camera = SDK.getCamera();

        public static void main(string[] args) {
            // ...
            Image image = camera.takeSnapshot();
            // ...
        }
    }
    // end::SmartphoneApp[]
}