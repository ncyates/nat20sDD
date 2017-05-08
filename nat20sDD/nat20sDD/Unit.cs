using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    class Unit
    {
        private string name;
        private int hp;
        private int strength;
        private int speed;
        private int defense;
        private int dexterity;
        protected List<Item> inventory;
        protected bool isGood;

        public Unit()
        {
            name = "blank";
            hp = 10;
            strength = 1;
            speed = 1;
            defense = 1;
            dexterity = 1;
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
        public List<Item> getInv()
        {
            return inventory;
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

        public void setDef(int d)
        {
            defense = d;
        }
        public void setDex(int d)
        {
            dexterity = d;
        }


        //checks if unit has 0 hp
        public bool isDead()
        {
            return (hp < 1);
        }

        //add item to inventory
        public void pickUp(Item i)
        {
            inventory.Add(i);
        }


    }
}
