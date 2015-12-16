using System;

namespace Strategy
{
    internal class Myself
    {
        private IWearingStrategy wearingStrategy;

        public Myself(IWearingStrategy wearingStrategy)
        {
            this.wearingStrategy = wearingStrategy;
        }

        public void ChangeStrategy(IWearingStrategy wearingStrategy)
        {
            this.wearingStrategy = wearingStrategy;
        }

        public void GoOutside()
        {
            var clothes = wearingStrategy.GetClothes();
            var accessories = wearingStrategy.GetAccessories();
            Console.WriteLine("Today I wore {0} and took {1}", clothes, accessories);
        }
    }
}