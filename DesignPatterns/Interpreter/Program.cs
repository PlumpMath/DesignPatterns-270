using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().RunInterpreterDemo();
        }
        public void RunInterpreterDemo()
        {
            // create syntax tree that represents sentence
            var truckWithGoods = PrepareTruckWithGoods();
            // get latest context
            var pricesContext = GetRecentPricesContext();
            // invoke Interpret
            var totalPriceForGoods = truckWithGoods.Interpret(pricesContext);

            Console.WriteLine("Total: {0}", totalPriceForGoods);
        }

        private CurrentPricesContext GetRecentPricesContext()
        {
            var pricesContext = new CurrentPricesContext();
            pricesContext.SetPrice("Bed", 400);
            pricesContext.SetPrice("TV", 100);
            pricesContext.SetPrice("Laptop", 500);
            return pricesContext;
        }

        public GoodsPackage PrepareTruckWithGoods()
        {
            var truck = new GoodsPackage() { GoodsInside = new List<Goods>() };

            var bed = new Bed();
            var doubleTriplePackedBed = new GoodsPackage()
            {
                GoodsInside = new List<Goods>() { new GoodsPackage() { GoodsInside = new List<Goods>() { bed } } }
            };
            truck.GoodsInside.Add(doubleTriplePackedBed);
            truck.GoodsInside.Add(new Tv());
            truck.GoodsInside.Add(new Tv());
            truck.GoodsInside.Add(new GoodsPackage()
            {
                GoodsInside = new List<Goods>() { new Laptop(), new Laptop(), new Laptop() }
            });

            return truck;
        }
    }
}
