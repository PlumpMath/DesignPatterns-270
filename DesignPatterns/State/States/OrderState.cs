using System;

namespace State
{
    class OrderState
    {
        public Order Order;

        public OrderState(Order order)
        {
            Order = order;
        }
        public virtual void AddProduct()
        {
            OperationIsNotAllowed("AddProduct");
        }
        public virtual void Register()
        {
            OperationIsNotAllowed("AddProduct");
        }
        public virtual void Grant()
        {
            OperationIsNotAllowed("Grant");
        }
        public virtual void Ship()
        {
            OperationIsNotAllowed("Ship");
        }
        public virtual void Invoice()
        {
            OperationIsNotAllowed("Invoice");
        }
        public virtual void Cancel()
        {
            OperationIsNotAllowed("Cancel");
        }
        private void OperationIsNotAllowed(string operationName)
        {
            Console.WriteLine("Operation {0} is not allowed for Order's state {1}", operationName, this.GetType().Name);
        }
    }
}