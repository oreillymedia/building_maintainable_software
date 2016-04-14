using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera
{

    // tag::SimpleDigitalCamera[]
    public interface ISimpleDigitalCamera
    {
        Image TakeSnapshot();

        void FlashLightOn();

        void FlashLightOff();
    }
    // end::SimpleDigitalCamera[]

}
