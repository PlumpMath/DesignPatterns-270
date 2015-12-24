using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
