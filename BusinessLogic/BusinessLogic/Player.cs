using System;

namespace BusinessLogic
{
	public class Player
	{
		private readonly int MAX_NAME_LENGTH = 15;
		private readonly int MIN_NAME_LENGTH = 5;
		public Player()
		{
		}

		public Player(string name)
		{
			Name = name;
			Health = 100;
		}

		public string Name { get => name; private set => SetName(value); }
		public int Health { get; private set; }

		private string name;
		private void SetName(string newName)
		{
			if (newName.Length > MAX_NAME_LENGTH || newName.Length < MIN_NAME_LENGTH)
				throw new InvalidPlayerDataException($"El nombre tiene que tener entre {MIN_NAME_LENGTH} y {MAX_NAME_LENGTH} caracteres");

			this.name = newName;
		}
	}
}