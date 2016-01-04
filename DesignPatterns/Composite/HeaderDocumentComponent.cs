using System;

namespace Composite
{
    class HeaderDocumentComponent : IDocumentComponent
    {
        public string GatherData()
        {
            return string.Format("<Header><MessageTime>{0}</MessageTime></Header>", DateTime.Now.ToLongTimeString());
        }
        public void AddComponent(IDocumentComponent documentComponent)
        {
            Console.WriteLine("Cannot add to leaf...");
        }
    }
}