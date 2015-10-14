package eu.sig.training.ch07;

@SuppressWarnings("unused")
// tag::ApplicationLauncher[]
public class ApplicationLauncher {

    public static void main(String[] args) {
        CloudServerFactory factory;
        if (args[1].equals("-azure")) {
            factory = new AzureCloudServerFactory();
        } else {
            factory = new AWSCloudServerFactory();
        }
        CloudServer computeServer = factory.launchComputeServer();
        CloudServer databaseServer = factory.launchDatabaseServer();
        // end::ApplicationLauncher[]
    }

}
