using System;

namespace Mediator
{
    class Hand : BodyPart
    {
        private bool _isSoft;
        private bool _isHurting;

        public Hand(Brain brain)
            : base(brain)
        {
        }
        public void FeelSomething()
        {
            Console.WriteLine("What you feel is soft? (Yes/No)");
            var answer = Console.ReadLine();
            if (answer != null && answer[0] == 'Y')
            {
                _isSoft = true;
            }
            Console.WriteLine("What you feel is hurting? (Yes/No)");
            answer = Console.ReadLine();
            if (answer != null && answer[0] == 'Y')
            {
                _isHurting = true;
            }

            Changed();
        }
        public void HitPersonNearYou()
        {
            Console.WriteLine("HAND: Just hit offender...");
        }
        public void Embrace()
        {
            Console.WriteLine("HAND: Embracing what is in front of you...");
        }
        public bool DoesItHurt()
        {
            return _isHurting;
        }
        public bool IsItNice()
        {
            return !_isHurting && _isSoft;
        }
    }
}