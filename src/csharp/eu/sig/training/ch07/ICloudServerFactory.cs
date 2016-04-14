namespace eu.sig.training.ch07
{
    // tag::CloudServerFactory[]
    public interface ICloudServerFactory
    {
        ICloudServer LaunchComputeServer();

        ICloudServer LaunchDatabaseServer();

        ICloudStorage CreateCloudStorage(long sizeGb);
    }
    // end::CloudServerFactory[]
}
