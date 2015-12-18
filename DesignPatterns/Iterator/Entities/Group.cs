using System.Collections.Generic;

namespace Iterator
{
    class Group
    {
        public List<Soldier> Soldiers { get; private set; }

        public Group()
        {
            Soldiers = new List<Soldier>();
        }

        public void AddNewSoldier(Soldier soldier)
        {
            Soldiers.Add(soldier);
        }
    }
}