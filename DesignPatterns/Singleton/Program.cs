namespace Singleton
{
        public class SingletonDemo
        {
            public static void Main()
            {
                DoHardWork();
            }

            public static void DoHardWork()
            {
                LoggerSingleton logger = LoggerSingleton.GetInstance();
                HardProcessor processor = new HardProcessor(5);
                logger.Log("Hard work started...");
                processor.ProcessTo(15);
                logger.Log("Hard work finished...");
            }
        }
}
