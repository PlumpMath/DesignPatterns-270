namespace Strategy
{
    class DefaultWearingStrategy : IWearingStrategy
    {
        public string GetClothes()
        {
            var r = 0;
            return "Default cloth";
        }

        public string GetAccessories()
        {
            return "Default accessories";
        }
    }
}