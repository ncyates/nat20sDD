using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
    public class Battle
    {

        public List<Hero> heroes;
        public List<Monster> monsters;
        public List<Item> loot;

        const int NUM_MONSTERS = 4;

        public Battle(List<Hero> characters)
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
