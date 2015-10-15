using System.Drawing;

namespace eu.sig.training.ch06.digitalcamera {

    // tag::SmartphoneApp[]
    public class SmartphoneApp {
        private static DigitalCamera camera = new DigitalCamera();

        public static void main(string[] args) {
            // ...        
            Image image = camera.takeSnapshot();
            // ...
        }
    }
    // end::SmartphoneApp[]

}