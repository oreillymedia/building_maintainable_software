using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera {

    // tag::SimpleDigitalCamera[]
    public interface SimpleDigitalCamera {
        Image takeSnapshot();

        void flashLightOn();

        void flashLightOff();
    }
    // end::SimpleDigitalCamera[]

}