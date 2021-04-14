using System;

namespace BusinessLogic
{
	public class Team
	{

		public static readonly Team NEUTRAL_TEAM = new Team("Neutral");

		public Team(string name)
		{
			Name = name;
		}

		public string Name { get => name ; private set => SetName(value); }

		private string name;

		private void SetName(string aName)
		{
			if (aName == null)
				throw new ArgumentNullException("El equipo debe tener un nombre");

			name = aName;
			
		}

		public override bool Equals(object obj)
		{
			if (obj == null || this.GetType() != obj.GetType())
			{
				return false;
			}

			var team = (Team)obj;
			return team.Name == this.Name;

		}

	}
}