using System;

namespace Interpreter
{
    class Bed : Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("Bed");
            Console.WriteLine("Bed: {0}", price);
            return price;
        }
    }
}