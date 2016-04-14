using System.Drawing;

namespace eu.sig.training.ch06.digitalcamera
{

#pragma warning disable 219
    // tag::SmartphoneApp[]
    public class SmartphoneApp
    {
        private static DigitalCamera camera = new DigitalCamera();

        public static void Main(string[] args)
        {
            // ...
            Image image = camera.TakeSnapshot();
            // ...
        }
    }
    // end::SmartphoneApp[]
#pragma warning restore 219
}
