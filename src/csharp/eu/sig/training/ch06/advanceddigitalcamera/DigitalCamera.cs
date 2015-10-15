using System.Drawing;

namespace eu.sig.training.ch06.advanceddigitalcamera {

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

        public Image takePanoramaSnapshot() {
            // end::DigitalCamera[]
            return Image.FromFile("");
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
}