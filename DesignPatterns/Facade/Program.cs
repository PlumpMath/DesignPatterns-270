using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var skiResortFacade = new SkiResortFacade();
            int weekendRestPrice = skiResortFacade.HaveGoodRest(175, 63, 41, 2, 3);
            Console.WriteLine("Price: {0}", weekendRestPrice);
        }
    }
}
