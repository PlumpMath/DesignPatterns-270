using System;

namespace FactoryMethod
{
    class EnterpriseLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("{0}: {1}", "Enterprise", message));
        }
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }
        public void LogVerboseInformation(string message)
        {
            throw new NotImplementedException();
        }
    }
}