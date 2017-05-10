//Battle Unit Tests ANDROID
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests.Droid
{
	[TestFixture]
	public class BattleTests
	{

		[SetUp]
		public void Setup() { }


		[TearDown]
		public void Tear() { }

		[Test]
		public void start()
		{
			Hero c = new Hero();
			Hero c2 = new Hero();
			Monster m = new Monster();
			List<Hero> charList = new List<Hero>();
			charList.Add(c);
			charList.Add(c2);
			Battle b = new Battle(charList);
			Assert.True(true);
		}


		[Test]
		public void attack()
		{
			Hero c = new Hero();
			Hero c2 = new Hero();
			Monster m = new Monster();
			List<Hero> charList = new List<Hero>();
			charList.Add(c);
			charList.Add(c2);

			Battle b = new Battle(charList);
			c.setStr(10);
			m.setHP(10);
			b.attack(c, m);
			Assert.IsTrue(m.isDead());
		}
	}
}