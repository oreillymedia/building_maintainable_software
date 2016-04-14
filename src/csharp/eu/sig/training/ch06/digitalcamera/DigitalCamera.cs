using System.Drawing;

namespace eu.sig.training.ch06.digitalcamera
{

    // tag::DigitalCamera[]
    public class DigitalCamera
    {
        public Image TakeSnapshot()
        {
            // ...
            // end::DigitalCamera[]
            return Image.FromFile("");
            // tag::DigitalCamera[]
        }

        public void FlashLightOn()
        {
            // ...
        }

        public void FlashLightOff()
        {
            // ...
        }
    }
    // end::DigitalCamera[]
}
