using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    public class Hero : Unit
    {
        //additional fields
        private int lvl;
        private int exp;
        private int score;

        public Hero() : base()
        {
            lvl = 0;
            exp = 0;
            score = 0;
            isGood = true;
        }

		public Hero(string name, int hp, int strength, int speed, int defense, int dexterity)
			: base(name, hp, strength, speed, defense, dexterity)
		{
			lvl = 0;
			exp = 0;
			score = 0;
			isGood = true;
		}

		public int getLvl()
        {
            return lvl;
        }
        public int getExp()
        {
            return exp;
        }
        public int getScore()
        {
            return score;
        }

        public void setlvl(int l)
        {
            lvl = l;
        }
        public void setExp(int e)
        {
            exp = e;
        }
        public void setScore(int s)
        {
            score = s;
        }



    }
}
