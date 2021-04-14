using System;

namespace BusinessLogic
{
	public class Player
	{
		private readonly int MAX_NAME_LENGTH = 15;
		public Player()
		{
		}

		public Player(string name)
		{
			Name = name;
		}

		public string Name { get => name; private set => SetName(value); }

		private string name;
		private void SetName(string newName)
		{
			if (newName.Length > MAX_NAME_LENGTH)
				throw new InvalidPlayerDataException($"El nombre no puede tener largo mayor a {MAX_NAME_LENGTH}");

			this.name = newName;
		}
	}
}