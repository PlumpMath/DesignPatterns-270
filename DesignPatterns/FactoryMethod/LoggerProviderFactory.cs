using System.Collections.Generic;

namespace FactoryMethod
{
    public class LoggerProviderFactory
    {
        private static Dictionary<LoggingProviders, ILogger> loggers = new Dictionary<LoggingProviders, ILogger>();

        public LoggerProviderFactory()
        {
            loggers.Add(LoggingProviders.Enterprise, new EnterpriseLogger());
            loggers.Add(LoggingProviders.Log4Net, new Log4NetLogger());
        }
        public static ILogger GetLoggingProvider(LoggingProviders logProviders)
        {
            return loggers.ContainsKey(logProviders) ? loggers[logProviders] : new EnterpriseLogger();
        }
    }
}