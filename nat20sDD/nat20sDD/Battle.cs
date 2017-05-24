using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace nat20sDD
{
	public class Battle
	{

		public List<Hero> heroes;
		public List<Monster> monsters;
		public List<Item> loot;
        public Game theGame;

		const int NUM_MONSTERS = 4;

		public Battle(List<Hero> characters, Game game)
		{
			heroes = characters;
			this.events = events;
			monsters = initMonsters();
            theGame = game;
		}

		// takes strength
		public int RollForDamage(int dieSize)
		{
			Random random = new Random();
			return random.Next(1, dieSize);
		}

		// takes dexterity
		public int RollForHit(int attackerStrength)
		{
			Random random = new Random();
			return random.Next(0, attackerStrength);
		}

		public int RollForDefense(int defenderDefense)
		{
			Random random = new Random();
			return random.Next(0, defenderDefense);
		}

		public int Roll20()
		{
			Random random = new Random();
			return random.Next(1, 20);
		}

		private void CheckforHealing(Unit a, Unit d)
		{
			int currentHP = a.getHP();
			int maxHP = a.getMaxHP();
			bool healing = false;
			foreach (Item item in a.inventory)
			{
				if (item.bodypart == "HEALING")
				{
					if (healing && currentHP < maxHP)
					{
						a.setHP(currentHP + item.tier > maxHP ? maxHP : currentHP + item.tier);
						a.inventory.Remove(item);
					}
				}
			}

            int temp = 0;
            if (theGame.forceCritHit == true)
            {
                Console.Out.WriteLine("CriticalHit");
                temp = 20;
            } else if(theGame.forceCritMiss == true)
            {
                temp = 1;
            }
            else
            {
                temp = Roll20();
            }
			
			//critical hit
			if (temp == 20)
			{
				// fists
				int damage = RollForDamage(2) * 2;
				bool offensive = false;
				foreach (Item item in a.inventory)
				{
					// weapon
					if (item.bodypart == "ATTKARM")
					{
						offensive = true;
						item.usage--;
						// discard item if counter is 0
						if (item.usage == 0) { a.inventory.Remove(item); }
						damage = RollForDamage(a.getStr()) * 2;
						d.setHP(d.getHP() - damage);
						Console.WriteLine(a.getName() + " did a Critical Hit for " + damage + " points of damage to " + d.getName() + "!");
						break;
					}
					// magic (single unit)
					else if (item.bodypart == "MAGICDIRECT")
					{
						offensive = true;
						item.usage--;
						// discard item if counter is 0
						if (item.usage == 0) { a.inventory.Remove(item); }
						damage = item.tier * 2;
						d.setHP(d.getHP() - damage);
						Console.WriteLine(a.getName() + " did a Critical Hit for " + damage + " points of magic damage to " + d.getName() + "!");
						break;
					}
					// magic (all units)
					else if (item.bodypart == "MAGICALL")
					{
						offensive = true;
						item.usage--;
						// discard item if counter is 0
						if (item.usage == 0) { a.inventory.Remove(item); }
						if (a.isGood)
						{
							foreach (Monster m in monsters)
							{
								m.setHP(m.getHP() - damage);
								Console.WriteLine(a.getName() + " did a Critical Hit for " + damage + " points of magic damage to all monsters!");
							}
						}
						else
						{
							foreach (Hero h in heroes)
							{
								h.setHP(h.getHP() - damage);
								Console.WriteLine(a.getName() + " did a Critical Hit for " + damage + " points of magic damage to all heroes!");
							}
						}
						break;
					}
				}
				if (!offensive)
				{
					d.setHP(d.getHP() - damage);
					Console.WriteLine(a.getName() + " hit with their fists for " + damage + " points of damage to " + d.getName());
				}
				int points = damage * 100;
				if (a.isGood)
				{
					a.setScore((a.getScore() + points));
					Console.WriteLine(a.getName() + " scored " + points + " points!");
				}
			}
			//regular roll
			else if (temp > 1)
			{
				if (RollForHit(a.getStr()) > RollForDefense(d.getDef()))
				{
					// fists
					int damage = RollForDamage(2) * 2;
					bool offensive = false;
					foreach (Item item in a.inventory)
					{
						// weapon
						if (item.bodypart == "ATTKARM")
						{
							offensive = true; 
							item.usage--;
							// discard item if counter is 0
							if (item.usage == 0) { a.inventory.Remove(item); }
							damage = RollForDamage(a.getStr()) * 2;
							d.setHP(d.getHP() - damage);
							Console.WriteLine(a.getName() + " hit for " + damage + " points of damage to " + d.getName());
							break;
						}
						// magic (single unit)
						else if (item.bodypart == "MAGICDIRECT")
						{
							offensive = true;
							item.usage--;
							// discard item if counter is 0
							if (item.usage == 0) { a.inventory.Remove(item); }
							damage = item.tier * 2;
							d.setHP(d.getHP() - damage);
							Console.WriteLine(a.getName() + " hit for " + damage + " points of magic damage to " + d.getName());
							break;
						}
						// magic (all units)
						else if (item.bodypart == "MAGICALL")
						{
							offensive = true;
							item.usage--;
							// discard item if counter is 0
							if (item.usage == 0) { a.inventory.Remove(item); }
							if (a.isGood)
							{
								foreach (Monster m in monsters)
								{
									m.setHP(m.getHP() - damage);
								}
								Console.WriteLine(a.getName() + " hit for " + damage + " points of magic damage to all enemies");
							}
							else
							{
								foreach (Hero h in heroes)
								{
									h.setHP(h.getHP() - damage);
								}
								Console.WriteLine(a.getName() + " hit for " + damage + " points of damage to all heroes");
							}
							break;
						}
					}
					if (!offensive)
					{
						d.setHP(d.getHP() - damage);
						Console.WriteLine(a.getName() + " hit with their fists for " + damage + " points of damage to " + d.getName());
					}
					int points = damage * 100;
					if (a.isGood)
					{
						a.setScore((a.getScore() + points));
						Console.WriteLine(a.getName() + " scored " + points + " points");
					}
				}
				else
				{
					Console.WriteLine(a.getName() + " Missed");
				}
				}
				//crit miss
				else
				{
					Console.WriteLine(a.getName() + "Critically Missed!");
					//Needs to Drop an item from the attacker
				}
			}

			public List<Monster> initMonsters()
			{
				List<Monster> monsterTeam = new List<Monster>();
				for (int i = 0; i < NUM_MONSTERS; i++)
				{
					Monster m = new Monster();
					m.setName("Ugly Monster " + (i + 1));
					m.setHP(75);
					m.setStr(8);
					m.setDex(6);
					m.setDef(4);
					m.setDifficulty(1);
					monsterTeam.Add(m);
				}
				return monsterTeam;
			}
		}
	}

