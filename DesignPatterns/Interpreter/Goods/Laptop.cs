using System;

namespace Interpreter
{
    class Laptop : Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("Laptop");
            Console.WriteLine("Laptop: {0}", price);
            return price;
        }
    }
}