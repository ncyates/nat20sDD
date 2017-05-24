using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
    public class Item
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int strength { get; set; }
        public int speed { get; set; }
        public int defense { get; set; }
        public int dexterity { get; set; }


        public Item(string n, int h, int str, int spd, int def, int dex)
        {
            name = n;
            hp = h;
            strength = str;
            speed = spd;
            defense = def;
            dexterity = dex;
        }

    }
}
