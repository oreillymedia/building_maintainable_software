using System;

namespace eu.sig.training.ch07 {
    // tag::CloudServerFactory[]
    public interface ICloudServerFactory {
        ICloudServer launchComputeServer();

        ICloudServer launchDatabaseServer();

        ICloudStorage createCloudStorage(long sizeGb);
    }
    // end::CloudServerFactory[]
}