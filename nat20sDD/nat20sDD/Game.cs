﻿using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    public class Game
    {

        public List<Hero> heroes;
        const int NUM_HEROES = 4;
        public Battle battle;
        int battleCount;
        public int totalScore;
        public Dictionary<string, bool> settingsMap = new Dictionary<string, bool>();
        
        public bool debugModeOn = true;
        public bool forceCritHit = false;
        public bool forceCritMiss = false;
        public bool itemUsageOn = false;
        public bool magicEnabled = true;
        public bool healingEnabled = true;
        public bool battleEventsOn = true;
        public bool serverItemsOn = true;
        public bool randomItemsOn = true;
        public bool superItemsOn = true;

    

        public Game()
        {
            heroes = initHeroes();
			battle = new Battle(heroes,this); // HAAHAH, worst design ever
            utilityOutput(); // to check hero initialization
            battleCount = 0;
            totalScore = 0;
            /*
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("forceCritHit", false);
            settingsMap.Add("forceCritMiss", false);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            settingsMap.Add("debugModeOn", true);
            */

            

            Console.WriteLine("Heroes fought " + battleCount + " battles.");
            Console.WriteLine("The Heroes scored " + totalScore + " points!\n\n");
        }


        //function to create heroes team
        public List<Hero> initHeroes()
        {
            List<Hero> team = new List<Hero>();
            for(int i = 0; i < NUM_HEROES; i++)
            {
                Hero h = new Hero();
                h.setName("Strong dude " + (i+1));
                h.setHP(100);
                h.setStr(10);
                h.setDex(10);
                h.setDef(10);
                h.setlvl(1);
                team.Add(h);                
            }
            return team;
        }

        public void play()
        {
                battleCount++;
                while(heroTeamLives() && monsterTeamLives(battle.monsters))
                {
                    for (int i = 0; i < NUM_HEROES; i++)
                    {
                        if (!heroes[i].isDead())
                        {
                            int target = findTargetMonster(battle.monsters);
                            if (target == -1)
                            {
                                Console.WriteLine("\n\n\nAll the monsters are dead!");
                                sumScores();
                                Console.WriteLine("The Heroes scored " + totalScore + " points!\n\n");
                                break;
                            }
                            battle.TheAttackingCharacterAttemptsToAttackTheDefendingCharacterDuringABattleSequence(heroes[i], battle.monsters[target]);
                        }
                        if (!battle.monsters[i].isDead())
                        {
                            int target = findTargetHero();
                            if (target == -1)
                            {
                                Console.WriteLine("n\n\nAll the heroes are dead.");
                                sumScores();
                                break;
                            }
                            battle.TheAttackingCharacterAttemptsToAttackTheDefendingCharacterDuringABattleSequence(battle.monsters[i], heroes[target]);
                        }
                    }
            }
        }

        public void utilityOutput()
        {
            for(int i = 0; i < this.heroes.Count; i++)
            {
                Console.WriteLine(this.heroes[i].getName());
            }
        }

        public bool heroTeamLives()
        {
            int numAlive = NUM_HEROES;
            foreach(Hero h in heroes)
            {
                if (h.isDead())
                {
                    numAlive--;
                }
            }
            if(numAlive == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool monsterTeamLives(List<Monster> monTeam)
        {
            int numAlive = NUM_HEROES;
            foreach (Monster m in monTeam)
            {
                if (m.isDead())
                {
                    numAlive--;
                }
            }
            if (numAlive == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int findTargetMonster(List<Monster> monTeam)
        {
            for(int i = 0; i < NUM_HEROES; i++)
            {
                if (!monTeam[i].isDead())
                {
                    return i;
                }
            }
            return -1;
        }

        public int findTargetHero()
        {
            for (int i = 0; i < NUM_HEROES; i++)
            {
                if (!heroes[i].isDead())
                {
                    return i;
                }
            }
            return -1;
        }

        public void sumScores()
        {
            foreach(Hero h in heroes)
            {
                totalScore += h.getScore();
            }
        }
        


        public int RollRange(int low, int high)
        {
            Random random = new Random();
            return random.Next(low, high);
        }
    }
}
