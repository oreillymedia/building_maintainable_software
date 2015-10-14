package eu.sig.training.ch07;

// tag::CloudServerFactory[]
public interface CloudServerFactory {
    CloudServer launchComputeServer();

    CloudServer launchDatabaseServer();

    CloudStorage createCloudStorage(long sizeGb);
}
// end::CloudServerFactory[]