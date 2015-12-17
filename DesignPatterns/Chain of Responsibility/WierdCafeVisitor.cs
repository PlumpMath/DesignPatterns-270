namespace Chain_of_Responsibility
{
    abstract class WierdCafeVisitor
    {
        public WierdCafeVisitor CafeVisitor { get; private set; }
        protected WierdCafeVisitor(WierdCafeVisitor cafeVisitor)
        {
            CafeVisitor = cafeVisitor;
        }
        public virtual void HandleFood(Food food)
        {
            // If I cannot handle other food, passing it to my successor
            if (CafeVisitor != null)
            {
                CafeVisitor.HandleFood(food);
            }
        }
    }
}