namespace State
{
    class Granted : OrderState
    {
        public Granted(Order order)
            : base(order)
        {
        }
        public override void AddProduct()
        {
            Order.DoAddProduct();
        }
        public override void Ship()
        {
            Order.DoShipping();
            Order.SetOrderState(new Shipped(Order));
        }
        public override void Cancel()
        {
            Order.DoCancel();
            Order.SetOrderState(new Cancelled(Order));
        }
    }
}
