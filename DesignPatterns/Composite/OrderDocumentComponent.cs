using System;

namespace Composite
{
    class OrderDocumentComponent : IDocumentComponent
    {
        private int OrderIdToGatherData { get; set; }

        public OrderDocumentComponent(int orderIdToGatherData)
        {
            OrderIdToGatherData = orderIdToGatherData;
        }

        public string GatherData()
        {
            string orderData;
            switch (OrderIdToGatherData)
            {
                case 0:
                    orderData = "Kindle;Book1;Book2";
                    break;
                default:
                    orderData = "Phone;Cable;Headset";
                    break;
            }

            return string.Format("<Order>{0}</Order>", orderData);
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            Console.WriteLine("Cannot add to leaf...");
        }
    }
}