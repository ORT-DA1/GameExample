using System;
using BusinessLogic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
	[TestClass]
	public class PlayerTest
	{

		Player validPlayer;
		string validName;

		[TestInitialize]
		public void TestSetUp()
		{
			validName = "pepepe";
			validPlayer = new Player(validName);
		}

		[TestMethod]
		public void CreatePlayerTest()
		{
			Player newPlayer = new Player();
			Assert.IsNotNull(newPlayer);
		}

		[TestMethod]
		public void CreatePlayerWithNameTest()
		{
			Assert.AreEqual(validName, validPlayer.Name);
		}

		
		[TestMethod]
		[ExpectedException(typeof(InvalidPlayerDataException))]
		public void NameTooLongTest()
		{
			string longName = "";
			for (int i = 0; i < Player.MAX_NAME_LENGTH + 1; i++)
			{
				longName += "A";
			}

			Player newPlayer = new Player(longName);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidPlayerDataException))]
		public void NameTooShortTest()
		{
			string shortName = "";
			for (int i = 0; i < Player.MIN_NAME_LENGTH - 1; i++)
			{
				shortName += "A";
			}
			var player = new Player(shortName);
		}


		[TestMethod]
		public void GetHealthPointsTest()
		{
			Assert.AreEqual(Player.INITIAL_HEALTH, validPlayer.Health);

		}

	}
}
