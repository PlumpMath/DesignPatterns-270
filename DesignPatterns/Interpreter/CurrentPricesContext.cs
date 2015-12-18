using System;
using System.Collections.Generic;

namespace Interpreter
{
    class CurrentPricesContext
    {
        Dictionary<string, int> prices = new Dictionary<string, int>();

        public CurrentPricesContext()
        {
            prices.Add("Bed", 3000);
            prices.Add("TV", 400);
            prices.Add("Laptop", 1500);
        }

        public int GetPrice(string goodName)
        {
            if (prices.ContainsKey(goodName))
            {
                return prices[goodName];
            }
            else
            {
                throw new ArgumentException("Could not get price for the good that is not registered.");
            }
        }

        public void SetPrice(string goodName, int cost)
        {
            if (prices.ContainsKey(goodName))
            {
                prices[goodName] = cost;
            }
            else
            {
                prices.Add(goodName, cost);
            }
        }
    }

    class CurrentPricesContextImpl : CurrentPricesContext
    {
    }
}