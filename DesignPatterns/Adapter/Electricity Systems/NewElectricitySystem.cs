namespace Adapter
{
    class NewElectricitySystem : INewElectricitySystem
    {
        public string MatchWideSocket()
        {
            return "220V";
        }
    }
}