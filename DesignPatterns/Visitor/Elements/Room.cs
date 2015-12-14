using Visitor.Interfaces;

namespace Visitor.Elements
{
    internal class Room : IElement
    {
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public int RoomNumber { get; private set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}