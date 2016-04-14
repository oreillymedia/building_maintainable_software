using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera
{

    // tag::DigitalCamera[]
    public class DigitalCamera : ISimpleDigitalCamera
    {
        // ...
        // end::DigitalCamera[]
        public Image TakeSnapshot()
        {
            return null;
        }

        public void FlashLightOn()
        {
        }

        public void FlashLightOff()
        {
        }
        // tag::DigitalCamera[]
    }
    // end::DigitalCamera[]
}
