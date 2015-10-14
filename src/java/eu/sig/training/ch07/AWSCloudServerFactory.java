package eu.sig.training.ch07;

// tag::AWSCloudServerFactory[]
public class AWSCloudServerFactory implements CloudServerFactory {
    public CloudServer launchComputeServer() {
        return new AWSComputeServer();
    }

    public CloudServer launchDatabaseServer() {
        return new AWSDatabaseServer();
    }

    public CloudStorage createCloudStorage(long sizeGb) {
        return new AWSCloudStorage(sizeGb);
    }
}
// end::AWSCloudServerFactory[]