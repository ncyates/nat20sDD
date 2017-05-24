//Item Unit Tests ANDROID
using System;
using NUnit.Framework;

namespace UnitTests.Droid
{
	[TestFixture]
	public class ItemTests
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
