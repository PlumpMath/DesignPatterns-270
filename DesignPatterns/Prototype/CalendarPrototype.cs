namespace Prototype
{
    public class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfPrototype = (CalendarPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}