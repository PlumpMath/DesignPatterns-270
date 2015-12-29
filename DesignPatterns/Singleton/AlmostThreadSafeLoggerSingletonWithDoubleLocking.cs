using System;

namespace Singleton
{
    public class AlmostThreadSafeLoggerSingletonWithDoubleLocking
    {
        private AlmostThreadSafeLoggerSingletonWithDoubleLocking()
        {
            // Читаємо дані із якогось файлу і дістаємо номер останнього запису
            // _logCount = вичитане значення
        }
        private int _logCount = 0;
        private volatile static AlmostThreadSafeLoggerSingletonWithDoubleLocking _loggerInstance;
        public static AlmostThreadSafeLoggerSingletonWithDoubleLocking GetInstance()
        {
            if (_loggerInstance == null)
            {
                lock (_loggerInstance)
                {
                    if (_loggerInstance == null)
                    {
                        _loggerInstance = new AlmostThreadSafeLoggerSingletonWithDoubleLocking();
                    }
                    else
                    {
                        return _loggerInstance;
                    }
                }
                return _loggerInstance;
            }
            return _loggerInstance;
        }

        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}