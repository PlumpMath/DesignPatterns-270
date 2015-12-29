using System;

namespace Memento
{
    public class GameState
    {
        public GameState(double health, int killedMonsters)
        {
            Health = health;
            KilledMonsters = killedMonsters;
        }

        public double Health { get; set; }
        public int KilledMonsters { get; set; }

        public override string ToString()
        {
            return string.Format("Health: {0}{1}Killed Monsters: {2}", Health, Environment.NewLine, KilledMonsters);
        }
    }
}