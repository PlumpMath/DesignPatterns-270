namespace Strategy
{
    class DefaultWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            return "Default cloth";
        }

        public string GetAccessories()
        {
            return "Default accessories";
        }
    }
}