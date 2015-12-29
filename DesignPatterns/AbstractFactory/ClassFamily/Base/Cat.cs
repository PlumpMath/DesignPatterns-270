namespace AbstractFactory
{
    public abstract class Cat : AnimalToy
    {
        protected Cat(string name) : base(name) { }
    }
}