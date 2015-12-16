namespace State
{
    class Registered : OrderState
    {
        public Registered(Order order)
            : base(order)
        {
        }

        public override void AddProduct()
        {
            Order.DoAddProduct();
        }

        public override void Grant()
        {
            Order.DoGrant();
            Order.SetOrderState(new Granted(Order));
        }

        public override void Cancel()
        {
            Order.DoCancel();
            Order.SetOrderState(new Cancelled(Order));
        }
    }
}