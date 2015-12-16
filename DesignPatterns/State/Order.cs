using System;
using System.Collections.Generic;

namespace State
{
    class Order
    {
        private OrderState state;
        private List<Product> products = new List<Product>();

        public Order()
        {
            state = new NewOrder(this);
        }
        public void SetOrderState(OrderState state)
        {
            this.state = state;
        }
        public void WriteCurrentStateName()
        {
            Console.WriteLine("Current Order's state: {0}", state.GetType().Name);
        }
        //
        public void AddProduct(Product product)
        {
            products.Add(product);
            state.AddProduct();
        }

        public void Register()
        {
            state.Register();
        }

        public void Grant()
        {
            state.Grant();
        }

        public void Ship()
        {
            state.Ship();
        }

        public void Invoice()
        {
            state.Invoice();
        }

        public void Cancel()
        {
            state.Cancel();
        }


        public void DoShipping()
        {
            Console.WriteLine("Shipping...");
        }

        public void DoAddProduct()
        {
            Console.WriteLine("Adding product...");
        }

        public void DoCancel()
        {
            Console.WriteLine("Cancelation...");
        }

        public void DoGrant()
        {
            Console.WriteLine("Granting...");
        }

        public void DoRegister()
        {
            Console.WriteLine("Registration...");
        }

        public void DoInvoice()
        {
            Console.WriteLine("Invoicing...");
        }
    }
}
