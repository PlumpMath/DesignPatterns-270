using System;

namespace Interpreter
{
    class Tv : Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("TV");
            Console.WriteLine("TV: {0}", price);
            return price;
        }
    }
}