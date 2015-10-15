using System;

namespace eu.sig.training.ch07 {
    // tag::AzureCloudServerFactory[]
    public class AzureCloudServerFactory : ICloudServerFactory {
        public ICloudServer launchComputeServer() {
            return new AzureComputeServer();
        }

        public ICloudServer launchDatabaseServer() {
            return new AzureDatabaseServer();
        }

        public ICloudStorage createCloudStorage(long sizeGb) {
            return new AzureCloudStorage(sizeGb);
        }
    }
    // end::AzureCloudServerFactory[]
}