﻿using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    class Hero : Unit
    {
        //additional fields
        private int lvl;
        private int exp;
        private int score;
        public Character() : base()
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
