using System.Drawing;

namespace eu.sig.training.ch06.simpledigitalcamera
{

#pragma warning disable 219
    // tag::SmartphoneApp[]
    public class SmartphoneApp
    {
        private static ISimpleDigitalCamera camera = SDK.GetCamera();

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
