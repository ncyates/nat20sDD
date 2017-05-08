using System;
using System.Collections.Generic;
using System.Text;

namespace nat20sDD
{
    class Monster :Unit
    {
        //additional fields
        private int pointVal;
        private int difficulty;
        public Monster() : base()
        {
            isGood = false;
        }

        public int getPoints()
        {
            return pointVal;
        }
        public int getDifficulty()
        {
            return difficulty;
        }

        public void setPoint(int p)
        {
            pointVal = p;
        }
        public void setDifficulty(int d)
        {
            difficulty = d;
        }

    }
}
