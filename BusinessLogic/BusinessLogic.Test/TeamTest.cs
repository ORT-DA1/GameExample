using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
	[TestClass]
	public class TeamTest
	{
		[TestMethod]
		public void NewTeamTest()
		{
			var newTeam = new Team("myteam");
			Assert.IsNotNull(newTeam);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NameNotNullTest()
		{
			new Team(null);
		}

		[TestMethod]
		public void GetTeamNameTest()
		{
			var teamName = "teamName";
			var team = new Team(teamName);
			Assert.AreEqual(teamName, team.Name);
		}

		[TestMethod]
		public void EqualTeamTest()
		{
			var teamName = "teamName";
			var team1 = new Team(teamName);
			var team2 = new Team(teamName);
			Assert.AreEqual(team1, team2);
		}

		[TestMethod]
		public void NotEqualTeamTest()
		{
			var teamName1 = "teamName1";
			var teamName2 = "teamName2";
			var team1 = new Team(teamName1);
			var team2 = new Team(teamName2);
			Assert.AreNotEqual(team1, team2);
		}

		[TestMethod]
		public void DefaultTeamTest()
		{
			var neutralTeam = new Team("Neutral");
			Assert.IsNotNull(Team.NEUTRAL_TEAM);
			Assert.AreEqual(Team.NEUTRAL_TEAM, neutralTeam);
		}


	}
}
