using System;

namespace BusinessLogic
{
	public class InvalidPlayerDataException : Exception
	{
		public InvalidPlayerDataException(string message) : base(message)
		{
		}

		public InvalidPlayerDataException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}