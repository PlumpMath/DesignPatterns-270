using System;

namespace Builder
{
    public class BuilderDemo
    {
        public static void Main()
        {
            //Your system could have bulk of builders
            var tripBuilder = new TripLaptopBuilder();
            var gamingBuilder = new GamingLaptopBuilder();
            var shopForYou = new BuyLaptop();//director
            shopForYou.SetLaptopBuilder(gamingBuilder);//Customer answered that he wants to play
            shopForYou.ConstructLaptop();
            Laptop laptop = shopForYou.GetLaptop();//just get what he wants
            Console.WriteLine(laptop.ToString());

            shopForYou.SetLaptopBuilder(tripBuilder);
            shopForYou.ConstructLaptop();

            var tripLaptop = shopForYou.GetLaptop();
            Console.WriteLine(tripLaptop.ToString());
        }
    }
}