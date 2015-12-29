using System;

namespace Bridge
{
    class ConcreteSlabWallCreator : IWallCreator
    {
        public void BuildWallWithDoor()
        {
            Console.WriteLine("Concrete slab wall with door.");
        }
        public void BuildWallWithWindow()
        {
            Console.WriteLine("Concrete slab wall with window.");
        }
        public void BuildWall()
        {
            Console.WriteLine("Concrete slab wall.");
        }
    }
}