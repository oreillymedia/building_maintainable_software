using System.Drawing;

namespace eu.sig.training.ch06.digitalcamera {

    // tag::DigitalCamera[]
    public class DigitalCamera {
        public Image takeSnapshot() {
            // ...
            // end::DigitalCamera[]
            return Image.FromFile("");
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
}