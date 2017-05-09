using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    public class Game
    {

        public List<Hero> heroes;
        const int NUM_HEROES = 4;
        Battle battle;
        int battleCount;
        int totalScore;
        public Game()
        {
            heroes = initHeroes();
            utilityOutput(); // to check hero initialization
            battleCount = 0;
            totalScore = 0;
            play();
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
            while (heroTeamLives())
            {
                battle = new Battle(heroes);
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
                            battle.attack(heroes[i], battle.monsters[target]);
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
                            battle.attack(battle.monsters[i], heroes[target]);
                        }
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
        
    }
}
