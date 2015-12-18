using System;

namespace Iterator
{
    class SoldiersIterator
    {
        private readonly Army army;
        private bool heroIsIterated;
        private int currentGroup;
        private int currentGroupSoldier;

        public SoldiersIterator(Army army)
        {
            this.army = army;
            heroIsIterated = false;
            currentGroup = 0;
            currentGroupSoldier = 0;
        }

        public bool HasNext()
        {
            if (!heroIsIterated) return true;
            if (currentGroup < army.ArmyGroups.Count) return true;
            if (currentGroup == army.ArmyGroups.Count - 1)
                if (currentGroupSoldier < army.ArmyGroups[currentGroup].Soldiers.Count) return true;

            return false;
        }

        public Soldier Next()
        {
            Soldier nextSoldier;
            // we still not iterated all soldiers in current group
            if (currentGroup < army.ArmyGroups.Count)
            {
                if (currentGroupSoldier < army.ArmyGroups[currentGroup].Soldiers.Count)
                {
                    nextSoldier = army.ArmyGroups[currentGroup].Soldiers[currentGroupSoldier];
                    currentGroupSoldier++;
                }
                // moving to next group
                else
                {
                    currentGroup++;
                    currentGroupSoldier = 0;
                    return Next();
                }
            }
            // hero is the last who left the battlefield
            else if (!heroIsIterated)
            {
                heroIsIterated = true;
                return army.ArmyHero;
            }
            else
            {
                // THROW EXCEPTION HERE
                throw new Exception("End of colletion");
                //or set all counters to 0 and start again, but not recommended
            }
            return nextSoldier;
        }
    }
}