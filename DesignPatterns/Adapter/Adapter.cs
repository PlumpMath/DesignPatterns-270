namespace Adapter
{
    class Adapter : INewElectricitySystem
    {
        private readonly OldElectricitySystem _adaptee;
        public Adapter(OldElectricitySystem adaptee)
        {
            _adaptee = adaptee;
        }

        public string MatchWideSocket()
        {
            return _adaptee.MatchThinSocket();
        }
    }
}