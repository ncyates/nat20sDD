using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    class Battle
    {

        public List<Character> heroes;
        public List<Monster> monsters;
        public List<Item> loot;

        const int NUM_MONSTERS = 4;

        public Battle(List<Character> characters)
        {
            heroes = characters;
            for (int i = 0; i < NUM_MONSTERS; i++)
            {
                Monster m = new Monster();
                monsters.Add(m);
            }

        }

        public void attack(Unit a, Unit d)
        {
            d.setHP(d.getHP() - a.getStr());
        }

    }
}
