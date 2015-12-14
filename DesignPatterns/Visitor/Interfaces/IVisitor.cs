using Visitor.Elements;

namespace Visitor.Interfaces
{
    internal interface IVisitor
    {
        void Visit(OfficeBuilding building);
        void Visit(Floor floor);
        void Visit(Room room);
    }
}