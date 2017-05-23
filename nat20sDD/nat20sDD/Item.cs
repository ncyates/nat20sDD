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

		public string image { get; set; }
		public string description { get; set; }
		public int tier { get; set; }
		public string bodypart { get; set; }
		public string attribmod { get; set; }
		public int usage { get; set; }
		public string creator { get; set; }

		public Item(string img, string name, string desc, int tier, string bpart, string amod, 
			int usage, string creator)
		{
			image = img;
			this.name = name;
			description = desc;
			this.tier = tier;
			bodypart = bpart;
			attribmod = amod;
			this.usage = usage;
			this.creator = creator;
		}

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
