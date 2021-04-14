using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
	[TestClass]
	public class PlayerTest
	{
		[TestMethod]
		public void CreatePlayerTest()
		{
			Player newPlayer = new Player();
			Assert.IsNotNull(newPlayer);
		}

		[TestMethod]
		public void CreatePlayerWithNameTest()
		{
			string name = "pepe";
			Player newPlayer = new Player(name);
			Assert.AreEqual(name, newPlayer.Name);
		}

		
		[TestMethod]
		[ExpectedException(typeof(InvalidPlayerDataException))]
		public void NameTooLongTest()
		{
			string longName = "";
			for (int i = 0; i < 16; i++)
			{
				longName += "A";
			}

			Player newPlayer = new Player(longName);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidPlayerDataException))]
		public void NameTooShortTest()
		{
			var shortName = "abc";
			var player = new Player(shortName);
		}

	}
}
