using System;
using System.Collections.Generic;

namespace Flyweight
{
    class UnitImagesFactory
    {
        public static Dictionary<Type, Image> Images = new Dictionary<Type, Image>();
        public static Image CreateDragonImage()
        {
            if (!Images.ContainsKey(typeof(Dragon)))
            {
                Images.Add(typeof(Dragon), Image.Load("Dragon.jpg"));
            }
            return Images[typeof(Dragon)];
        }
        public static Image CreateGoblinImage()
        {
            if (!Images.ContainsKey(typeof(Goblin)))
            {
                Images.Add(typeof(Goblin), Image.Load("Goblin.jpg"));
            }
            return Images[typeof(Goblin)];
        }
    }
}