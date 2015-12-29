namespace Bridge
{
    public class BridgeDemo
        {
            public static void Main()
            {
                // We have two wall creating crews - concrete blocks one and bricks one
                var brickWallCreator = new BrickWallCreator();
                var conctreteSlabWallCreator = new ConcreteSlabWallCreator();

                var buildingCompany = new BuldingCompany();
                buildingCompany.BuildFoundation();

                buildingCompany.WallCreator = conctreteSlabWallCreator;
                buildingCompany.BuildRoom();

                // Company can easily switch to another wall crew to continue building rooms
                // with another material
                buildingCompany.WallCreator = brickWallCreator;
                buildingCompany.BuildRoom();
                buildingCompany.BuildRoom();

                buildingCompany.BuildRoof();
            }
        }
    
}
