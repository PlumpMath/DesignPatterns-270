using System;

namespace Mediator
{
    class Leg : BodyPart
    {
        public Leg(Brain brain)
            : base(brain)
        {
        }
        public void Kick()
        {
            Console.WriteLine("LEG: Just kicked offender in front of you..");
        }
        public void StepBack()
        {
            Console.WriteLine("LEG: Stepping back...");
        }
        public void StepForward()
        {
            Console.WriteLine("LEG: Stepping forward...");
        }
    }
}