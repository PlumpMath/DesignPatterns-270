﻿using System;

namespace Strategy
{
    class Myself
    {
        private IWearingStrategy _wearingStrategy = new DefaultWearingStrategy();

        public Myself(IWearingStrategy wearingStrategy)
        {
            _wearingStrategy = wearingStrategy;
        }

        public void ChangeStrategy(IWearingStrategy wearingStrategy)
        {
            _wearingStrategy = wearingStrategy;
        }

        public void GoOutside()
        {
            var clothes = _wearingStrategy.GetClothes();
            var accessories = _wearingStrategy.GetAccessories();
            Console.WriteLine("Today I wore {0} and took {1}", clothes, accessories);
        }
    }
}