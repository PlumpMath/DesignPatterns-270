using System;

namespace Chain_of_Responsibility
{
    class GirlFriend : WierdCafeVisitor
    {
        public GirlFriend(WierdCafeVisitor cafeVisitor)
            : base(cafeVisitor)
        {
        }

        public override void HandleFood(Food food)
        {
            if (food.Name == "Cappuccino")
            {
                Console.WriteLine("GirlFriend: My lovely cappuccino!!!");
                return;
            }
            base.HandleFood(food);
        }
    }
}