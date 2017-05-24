using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    public class Game
    {

        public List<Hero> heroes;
		public List<BattleEvent> events;
		public List<Item> items;
		public List<string> heroImgs;
		public List<string> monstImgs;
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
			heroImgs = new List<string>();
			heroImgs.Add("https://s-media-cache-ak0.pinimg.com/originals/dd/ac/24/ddac24e8b1291f8f27d9826cb9b54f94.jpg");
			heroImgs.Add("http://annawrites.com/blog/wp-content/uploads/2012/02/family-guy-267x300.jpg");
			heroImgs.Add("http://annawrites.com/blog/wp-content/uploads/2012/02/mad-scientist-300x300.jpg");
			heroImgs.Add("https://img.clipartfest.com/d34754abc7b9f37aa56c16ba207779c0_ra-zombie-character-character-vs-character-clipart_618-464.jpeg");
			heroes = initHeroes();
			events = new List<BattleEvent>();
			items = new List<Item>();
			battle = new Battle(heroes,this); // HAAHAH, worst design ever
            utilityOutput(); // to check hero initialization
            battleCount = 0;
            totalScore = 0;

            Console.WriteLine("Heroes fought " + battleCount + " battles.");
            Console.WriteLine("The Heroes scored " + totalScore + " points!\n\n");
        }


        //function to create heroes team
        public List<Hero> initHeroes()
        {
			Random imgchoice = new Random();
			List<Hero> team = new List<Hero>();
            for(int i = 0; i < NUM_HEROES; i++)
            {
				int choice = imgchoice.Next(0, 3);
				Hero h = new Hero();
                h.setName("Strong dude " + (i+1));
                h.setHP(100);
                h.setStr(10);
                h.setDex(10);
                h.setDef(10);
                h.setlvl(1);
				h.imgUri = heroImgs[choice];
				team.Add(h);                
            }
            return team;
        }

        public void play()
        {
				battle.events = events;
				battle.loot = items;
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
