using System;

namespace AbstractFactory
{
    public class AbstractFactoryDemo
    {
        public static void Main()
        {
            RunFactory(new TeddyToysFactory());
            RunFactory(new WoodenToysFactory());
        }

        private static void RunFactory(IToyFactory toyFactory)
        {
            Bear bear = toyFactory.GetBear();
            Cat cat = toyFactory.GetCat();
            Console.WriteLine("I've got {0} and {1}", bear.Name, cat.Name);
        }
    }
}
