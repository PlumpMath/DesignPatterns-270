using System.Collections.Generic;
using Visitor.Interfaces;

namespace Visitor.Elements
{
    internal class Floor : IElement
    {
        private readonly IList<Room> rooms = new List<Room>();

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
        }

        public int FloorNumber { get; private set; }

        public IEnumerable<Room> Rooms => rooms;
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var room in Rooms)
            {
                room.Accept(visitor);
            }
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
    }
}