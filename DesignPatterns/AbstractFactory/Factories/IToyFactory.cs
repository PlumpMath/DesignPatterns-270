namespace AbstractFactory
{
    public interface IToyFactory
    {
        Bear GetBear();
        Cat GetCat();
    }
}