using System.Collections.Generic;
using Visitor.Interfaces;

namespace Visitor.Elements
{
    internal class OfficeBuilding : IElement
    {
        private readonly IList<Floor> floors = new List<Floor>();

        public OfficeBuilding(string buildingName, int age, int electricitySystemId)
        {
            BuildingName = buildingName;
            Age = age;
            ElectricitySystemId = electricitySystemId;
        }

        public string BuildingName { get; private set; }
        public int Age { get; set; }
        public int ElectricitySystemId { get; set; }

        public IEnumerable<Floor> Floors => floors;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var floor in Floors)
            {
                floor.Accept(visitor);
            }
        }

        public void AddFloor(Floor floor)
        {
            floors.Add(floor);
        }
    }
}