using System;

namespace Observer
{
    class ConservativePlayer : IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight)subject;

            BoxerToPutMoneyOn = boxFight.BoxerAScore < boxFight.BoxerBScore 
                ? "I put on boxer B, better be safe!" 
                : "I put on boxer A, better be safe!";

            Console.WriteLine("CONSERVATIVEPLAYER:{0}", BoxerToPutMoneyOn);
        }
    }
}