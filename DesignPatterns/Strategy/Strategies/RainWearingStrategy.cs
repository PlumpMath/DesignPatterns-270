namespace Strategy
{
    class RainWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "Warm clothes";
        }

        public string GetAccessories()
        {
            return "Wookie";
        }
    }
}