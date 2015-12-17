using System;

namespace Chain_of_Responsibility
{
    class Me : WierdCafeVisitor
    {
        public Me(WierdCafeVisitor cafeVisitor)
            : base(cafeVisitor)
        {
        }

        public override void HandleFood(Food food)
        {
            if (food.Name.Contains("Soup"))
            {
                Console.WriteLine("Me: I like Soup. It went well.");
            }
            base.HandleFood(food);
        }
    }
}