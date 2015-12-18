using System.Collections.Generic;

namespace Iterator
{
    class Army
    {
        public Hero ArmyHero;
        public List<Group> ArmyGroups { get; private set; }

        public Army(Hero armyHero)
        {
            ArmyHero = armyHero;
            ArmyGroups = new List<Group>();
        }

        public void AddArmyGroup(Group group)
        {
            ArmyGroups.Add(group);
        }
    }
}