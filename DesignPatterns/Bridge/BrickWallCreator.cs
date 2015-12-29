using System;

namespace Bridge
{
    class BrickWallCreator : IWallCreator
    {
        public void BuildWallWithDoor()
        {
            Console.WriteLine("Brick wall with door.");
        }
        public void BuildWallWithWindow()
        {
            Console.WriteLine("Brick wall with window.");
        }
        public void BuildWall()
        {
            Console.WriteLine("Brick wall.");
        }
    }
}