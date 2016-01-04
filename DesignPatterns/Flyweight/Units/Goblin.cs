namespace Flyweight
{
    class Goblin : Unit
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 8;
            //old
            Picture = Image.Load("Goblin.jpg");
            //new
            Picture = UnitImagesFactory.CreateGoblinImage();
        }
    }
}