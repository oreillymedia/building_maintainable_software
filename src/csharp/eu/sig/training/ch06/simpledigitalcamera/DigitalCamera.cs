using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera {
   
    // tag::DigitalCamera[]
    public class DigitalCamera : SimpleDigitalCamera {
        // ...
        // end::DigitalCamera[]
        public Image takeSnapshot() {
            return null;
        }

        public void flashLightOn() {
        }

        public void flashLightOff() {
        }
        // tag::DigitalCamera[]
    }
    // end::DigitalCamera[]
}