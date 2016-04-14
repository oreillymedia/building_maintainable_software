namespace eu.sig.training.ch06.simpledigitalcamera
{

    public class SDK
    {
        public static ISimpleDigitalCamera GetCamera()
        {
            return new DigitalCamera();
        }
    }
}
