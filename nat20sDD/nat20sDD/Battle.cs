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
            monsters = initMonsters();

        }

        public void attack(Unit a, Unit d)
        {
            int damage = a.getStr();
            d.setHP(d.getHP() - damage);
            Console.WriteLine(a.getName() + " did " + damage + " points of damage to " + d.getName());
            int points = damage * 100;
            if (a.isGood)
            {
                a.setScore((a.getScore() + points));
                Console.WriteLine(a.getName() + " scored " + points + " points!");
            }
            
            
        }

        public List<Monster> initMonsters()
        {
            List<Monster> monsterTeam = new List<Monster>();
            for (int i = 0; i < NUM_MONSTERS; i++)
            {
                Monster m = new Monster();
                m.setName("Ugly Monster " + (i + 1));
                m.setHP(75);
                m.setStr(8);
                m.setDex(6);
                m.setDef(4);
                m.setDifficulty(1);
                monsterTeam.Add(m);
            }
            return monsterTeam;
        }
    }
}
