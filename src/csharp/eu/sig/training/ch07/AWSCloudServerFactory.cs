namespace eu.sig.training.ch07
{
    // tag::AWSCloudServerFactory[]
    public class AWSCloudServerFactory : ICloudServerFactory
    {
        public ICloudServer LaunchComputeServer()
        {
            return new AWSComputeServer();
        }

        public ICloudServer LaunchDatabaseServer()
        {
            return new AWSDatabaseServer();
        }

        public ICloudStorage CreateCloudStorage(long sizeGb)
        {
            return new AWSCloudStorage(sizeGb);
        }
    }
    // end::AWSCloudServerFactory[]
}
