namespace eu.sig.training.ch07
{
    // tag::ApplicationLauncher[]
    public class ApplicationLauncher
    {

        public static void Main(string[] args)
        {
            ICloudServerFactory factory;
            if (args[1].Equals("-azure"))
            {
                factory = new AzureCloudServerFactory();
            }
            else
            {
                factory = new AWSCloudServerFactory();
            }
            ICloudServer computeServer = factory.LaunchComputeServer();
            ICloudServer databaseServer = factory.LaunchDatabaseServer();
            // end::ApplicationLauncher[]
        }
    }
}
