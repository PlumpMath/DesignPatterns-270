namespace State
{
    class Shipped : OrderState
    {
        public Shipped(Order order)
            : base(order)
        {
        }

        public override void Invoice()
        {
            Order.DoInvoice();
            Order.SetOrderState(new Invoiced(Order));
        }
    }
}