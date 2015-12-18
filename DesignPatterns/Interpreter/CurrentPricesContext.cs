using System;
using System.Collections.Generic;

namespace Interpreter
{
    class CurrentPricesContext
    {
        Dictionary<string, int> _prices = new Dictionary<string, int>();

        public CurrentPricesContext()
        {
            _prices.Add("Bed", 3000);
            _prices.Add("TV", 400);
            _prices.Add("Laptop", 1500);
        }

        public int GetPrice(string goodName)
        {
            if (_prices.ContainsKey(goodName))
            {
                return _prices[goodName];
            }
            else
            {
                throw new ArgumentException("Could not get price for the good that is not registered.");
            }
        }

        public void SetPrice(string goodName, int cost)
        {
            if (_prices.ContainsKey(goodName))
            {
                _prices[goodName] = cost;
            }
            else
            {
                _prices.Add(goodName, cost);
            }
        }
    }

    class CurrentPricesContextImpl : CurrentPricesContext
    {
    }
}