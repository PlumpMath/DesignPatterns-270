namespace State
{
    class NewOrder : OrderState
    {
        public NewOrder(Order order)
            : base(order)
        {
        }

        public override void AddProduct()
        {
            Order.DoAddProduct();
        }

        public override void Register()
        {
            Order.DoRegister();
            Order.SetOrderState(new Registered(Order));
        }

        public override void Cancel()
        {
            Order.DoCancel();
            Order.SetOrderState(new Cancelled(Order));
        }
    }
}