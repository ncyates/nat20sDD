using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
    public class Unit
    {
        private string name;
        private int hp;
		private int maxhp;
        private int strength;
        private int speed;
        private int defense;
        private int dexterity;
        public List<Item> inventory;
        public int score;
        public bool isGood;

        public Unit() : this("blank", 10, 1, 1, 1, 1)
        {
        }

		public Unit(string name, int hp, int strength, int speed, int defense, int dexterity)
		{
			this.name = name;
			this.hp = hp;
			this.maxhp = hp;
			this.strength = strength;
			this.speed = speed;
			this.defense = defense;
			this.dexterity = dexterity;
            this.score = 0;
			inventory = new List<Item>();
		}

        public string getName()
        {
            return name;
        }
        public int getHP()
        {
            return hp;
        }
		public int getMaxHP()
		{
			return maxhp;
		}
        public int getStr()
        {
            return strength;
        }
        public int getSpd()
        {
            return speed;
        }
        public int getDef()
        {
            return defense;
        }
        public int getDex()
        {
            return dexterity;
        }

        public void setScore(int s)
        {
            score = s;
        }

        public int getScore()
        {
            return score;
        }
        //Set methods
        public void setName(string n)
        {
            name = n;
        }

        public void setHP(int h)
        {
            hp = h;
        }
        public void setStr(int s)
        {
            strength = s;
        }
		public void setSpd(int s)
		{
			speed = s;
		}
		public void setDef(int d)
        {
            defense = d;
        }
        public void setDex(int d)
        {
            dexterity = d;
        }


        //returns true if unit's hp is below 0
        public bool isDead()
        {
            return (hp < 1);
        }

        //add item to inventory
        public void pickUp(Item i)
        {
			if (i.attribmod == "SPEED")
			{
				speed += i.tier;
			}
			else if (i.attribmod == "STRENGTH")
			{
				strength += i.tier;
			}
			else if (i.attribmod == "DEFENSE")
			{
				defense += i.tier;
			}
            inventory.Add(i);
        }


    }
}
