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

        // takes strength
        public int RollForDamage(int dieSize)
        {
            Random random = new Random();
            return random.Next(1, dieSize);
        }

        // takes dexterity
        public int RollForHit(int attackerStrength)
        {
            Random random = new Random();
            return random.Next(0, attackerStrength);
        }

        public int RollForDefense(int defenderDefense)
        {
            Random random = new Random();
            return random.Next(0, defenderDefense);
        }

        public int Roll20()
        {
            Random random = new Random();
            return random.Next(1, 20);
        }


        public void TheAttackingCharacterAttemptsToAttackTheDefendingCharacterDuringABattleSequence(Unit a, Unit d)
        {
            int temp = Roll20();
            //crit hit
            if (temp == 20)
            {
                int damage = RollForDamage(a.getStr()) * 2;
                d.setHP(d.getHP() - damage);
                Console.WriteLine(a.getName() + " did a Critical Hit for " + damage + " points of damage to " + d.getName() + "!");
                int points = damage * 100;
                if (a.isGood)
                {
                    a.setScore((a.getScore() + points));
                    Console.WriteLine(a.getName() + " scored " + points + " points!");
                }
            }
            //regular roll
            else if(temp > 1)
            {
                if (RollForHit(a.getStr()) > RollForDefense(d.getDef()))
                {
                    int damage = RollForDamage(a.getStr());
                    d.setHP(d.getHP() - damage);
                    Console.WriteLine(a.getName() + " hit for " + damage + " points of damage to " + d.getName());
                    int points = damage * 100;
                    if (a.isGood)
                    {
                        a.setScore((a.getScore() + points));
                        Console.WriteLine(a.getName() + " scored " + points + " points");
                    }
                }
                else
                {
                    Console.WriteLine(a.getName() + " Missed");
                }
            }
            //crit miss
            else
            {
                Console.WriteLine(a.getName() + "Critically Missed!");
                //Needs to Drop an item from the attacker
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

