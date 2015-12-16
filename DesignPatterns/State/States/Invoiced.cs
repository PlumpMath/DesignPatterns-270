namespace State
{
    class Invoiced : OrderState
    {
        public Invoiced(Order order)
            : base(order)
        {
        }
    }
}