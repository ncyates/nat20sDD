using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    public class Game
    {

        List<Hero> heroes;
        public Game()
        {
            heroes = initHeroes();
            utilityOutput();
        }


        //function to create heroes team
        public List<Hero> initHeroes()
        {
            List<Hero> team = new List<Hero>();
            for(int i = 0; i < 4; i++) //fix hardcode
            {
                Hero h = new Hero();
                h.setName("Strong dude " + (i+1));
                h.setHP(10);
                h.setStr(10);
                h.setDex(10);
                h.setDef(10);
                h.setlvl(1);
                team.Add(h);                
            }
            return team;
        }

        public void utilityOutput()
        {
            for(int i = 0; i < this.heroes.Count; i++)
            {
                Console.WriteLine(this.heroes[i].getName());
            }
        }

    }
}
