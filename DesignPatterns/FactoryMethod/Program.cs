namespace FactoryMethod
{
    public class FactoryMethodDemo
    {
        public static void Main()
        {
            var providerType = GetTypeOfLoggingProviderFromConfigFile();
            ILogger logger = LoggerProviderFactory.GetLoggingProvider(providerType);
            logger.LogMessage("Hello Factory Method Design Pattern.");
        }

        private static LoggingProviders GetTypeOfLoggingProviderFromConfigFile()
        {
            return LoggingProviders.Log4Net;
        }
    }
}