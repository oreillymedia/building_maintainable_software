package eu.sig.training.ch07;

// tag::AzureCloudServerFactory[]
public class AzureCloudServerFactory implements CloudServerFactory {
    public CloudServer launchComputeServer() {
        return new AzureComputeServer();
    }

    public CloudServer launchDatabaseServer() {
        return new AzureDatabaseServer();
    }

    public CloudStorage createCloudStorage(long sizeGb) {
        return new AzureCloudStorage(sizeGb);
    }
}
// end::AzureCloudServerFactory[]