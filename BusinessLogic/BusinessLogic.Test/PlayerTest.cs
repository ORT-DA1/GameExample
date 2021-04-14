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
		readonly Team neutralTeam = new Team("Neutral");

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
		public void DefaultNameTest()
		{
			Player newPlayer = new Player();
			Assert.AreEqual(newPlayer.Name, "Default name");
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

		[TestMethod]
		public void SetTeamTest()
		{
			var team = new Team("myteam");
			validPlayer.Team = team;
			Assert.AreEqual(team, validPlayer.Team);
		}

		[TestMethod]
		public void GetTeamTest()
		{
			var playerWithoutTeam = new Player(validName);
			Assert.IsNotNull(playerWithoutTeam.Team);
		}

		[TestMethod]
		public void GetNeutralTeamTest()
		{
			Assert.AreEqual(validPlayer.Team, neutralTeam);
		}
	}
}
