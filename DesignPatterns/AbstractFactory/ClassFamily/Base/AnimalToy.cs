namespace AbstractFactory
{
    public abstract class AnimalToy
    {
        protected AnimalToy(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}