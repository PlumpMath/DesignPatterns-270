using System;

namespace Observer
{
    class RiskyPlayer : IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight)subject;

            BoxerToPutMoneyOn = boxFight.BoxerAScore > boxFight.BoxerBScore 
                ? "I put on boxer B, if he win I get more!" 
                : "I put on boxer A, if he win I get more!";

            Console.WriteLine("RISKYPLAYER:{0}", BoxerToPutMoneyOn);
        }
    }
}