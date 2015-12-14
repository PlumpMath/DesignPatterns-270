using System;
using Visitor.Elements;
using Visitor.Interfaces;

namespace Visitor.Visitors
{
    internal class PlumbingSystemValidator : IVisitor
    {
        public void Visit(OfficeBuilding building)
        {
            var plumbingState = (building.Age < 30) ? "Good" : "Bad";
            var buildingAge = (building.Age < 30) ? "New" : "Old";
            Console.WriteLine("Plumbing state of building {0} probably is in {1} condition, since builing is {2}.", building.BuildingName, plumbingState, buildingAge);
        }

        public void Visit(Floor floor)
        {
            Console.WriteLine("Diagnosting plumbing on floor {0}.", floor.FloorNumber);
        }

        public void Visit(Room room)
        {
            // we do nothing, since rooms do not have separated plumbing systems
        }
    }
}