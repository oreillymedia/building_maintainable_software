using System;

namespace eu.sig.training.ch07 {
    // tag::AWSCloudServerFactory[]
    public class AWSCloudServerFactory : ICloudServerFactory {
        public ICloudServer launchComputeServer() {
            return new AWSComputeServer();
        }

        public ICloudServer launchDatabaseServer() {
            return new AWSDatabaseServer();
        }

        public ICloudStorage createCloudStorage(long sizeGb) {
            return new AWSCloudStorage(sizeGb);
        }
    }
    // end::AWSCloudServerFactory[]
}
