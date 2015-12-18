using System;
using System.Collections.Generic;

namespace Observer
{
    class BoxFight : ISubject
    {
        public List<IObserver> Observers { get; private set; }
        public int RoundNumber { get; private set; }
        private Random random = new Random();

        public int BoxerAScore { get; set; }
        public int BoxerBScore { get; set; }

        public BoxFight()
        {
            Observers = new List<IObserver>();
        }
        public void AttachObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void DetachObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void NextRound()
        {
            RoundNumber++;

            BoxerAScore += random.Next(0, 5);
            BoxerBScore += random.Next(0, 5);

            Notify();
        }
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}