namespace Visitor.Interfaces
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}