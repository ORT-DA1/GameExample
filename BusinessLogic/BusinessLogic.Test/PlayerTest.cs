using System;
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


		[TestMethod]
		public void GetHealthPointsTest()
		{
			Assert.AreEqual(100, validPlayer.Health);

		}

	}
}
