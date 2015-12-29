using System;

namespace FactoryMethod
{
    class Log4NetLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(string.Format("{0}: {1}", "Log4Net", message));
            // Вивід: [Log4Net: Hello Factory Method Design Pattern]
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