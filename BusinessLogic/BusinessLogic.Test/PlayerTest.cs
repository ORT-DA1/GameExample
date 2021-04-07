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

	}
}
