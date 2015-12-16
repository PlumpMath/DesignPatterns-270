namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Product beer = new Product();
            beer.Name = "MyBestBeer";
            beer.Price = 78000;

            Order order = new Order();
            order.WriteCurrentStateName();

            order.AddProduct(beer);
            order.WriteCurrentStateName();

            order.Register();
            order.WriteCurrentStateName();

            order.Grant();
            order.WriteCurrentStateName();

            order.Ship();
            order.WriteCurrentStateName();

            //trying to add more beer to already shipped order
            order.AddProduct(beer);
            order.WriteCurrentStateName();

            //order.Invoice();
            //order.WriteCurrentStateName();
        }
    }
}
