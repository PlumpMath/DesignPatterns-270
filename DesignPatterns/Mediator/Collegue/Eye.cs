using System;

namespace Mediator
{
    class Eye : BodyPart
    {
        private string _thingsAround = string.Empty;
        public Eye(Brain brain)
            : base(brain)
        {
        }

        public void SeeSomething()
        {
            Console.WriteLine("Enter what you see:");
            _thingsAround = Console.ReadLine();

            Changed();
        }
    }
}