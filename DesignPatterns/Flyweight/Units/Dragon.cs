namespace Flyweight
{
    class Dragon : Unit
    {
        public Dragon()
        {
            Name = "Dragon";
            Health = 50;
            //old
            Picture = Image.Load("Dragon.jpg");
            //new
            Picture = UnitImagesFactory.CreateDragonImage();
        }
    }
}