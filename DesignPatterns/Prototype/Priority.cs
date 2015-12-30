using System;

namespace Prototype
{
    public class Priority : ICloneable
    {
        private int _priority;

        private Priority(int priority)
        {
            _priority = priority;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static Priority High()
        {
            return new Priority(1);
        }

        public static Priority Low()
        {
            return new Priority(-1);
        }

        public void SetPriorityValue(int priority)
        {
            _priority = priority;
        }

        public bool IsHigh()
        {
            return _priority > 0;
        }
    }
}