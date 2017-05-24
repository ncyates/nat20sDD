//Hero Unit Tests ANDROID
using System;
using NUnit.Framework;

namespace UnitTests.Droid
{
	[TestFixture]
	public class HeroTests
	{
		[SetUp]
		public void Setup() { }


		[TearDown]
		public void Tear() { }

		[Test]
		public void isAlive()
		{
			var something = new Hero();
			Assert.True(!something.isDead());
		}

		[Test]
		public void dead()
		{
			var something = new Hero();
			something.setHP(0);

			if (something.getHP() == 0)
			{
				Assert.True(true);
			}
			else
			{
				Assert.False(true);
			}
		}

		[Test]
		public void addItem()
		{
			var something = new Hero();
			var x = new Item("Bronze Sword", 0, 1, 0, 1, 0);
			something.pickUp(x);
			var inv = something.getInv();
			if (inv.Count == 1)
			{
				Assert.True(true);
			}
			else
			{
				Assert.True(false);
			}
		}

		[Test]
		public void addItemCheckStats()
		{
			// Base : 10, 1, 1, 1, 1
			var something = new Hero();
			var x = new Item("Bronze Sword", 0, 1, 1, 1, 1);
			something.pickUp(x);
			Assert.IsTrue(something.getSpd() == 2);
		}

	}
}
