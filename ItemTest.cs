//Character Unit Tests ANDROID
using System;
using NUnit.Framework;
using nat20sDD;

namespace Tests
{
	[TestFixture]
	public class ItemTest
	{
		[SetUp]
		public void Setup() { }


		[TearDown]
		public void Tear() { }

		[Test]
		public void createItemGet()
		{
			var testItem = new Item("Bronze Sword", 0, 1, 0, 1, 0);
			Assert.True(testItem.strength == 1);
		}
	}
}
