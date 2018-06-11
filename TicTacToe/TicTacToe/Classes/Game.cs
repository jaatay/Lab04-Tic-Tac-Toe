using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToe
{
	public class Game
	{
		public string CheckWinner(string[] userOne, string[] userTwo)
		{
			string userOneValues = String.Join("", userOne);
			string userTwoValues = String.Join("", userTwo);
			Console.WriteLine($"User One values are: {userOneValues}");
			Console.WriteLine($"User Two values are: {userTwoValues}");

			//user one wins
			CheckOnePlayer(userOneValues, "One");
			CheckOnePlayer(userTwoValues, "Two");

			return "";
		}

		public void CheckOnePlayer(string playerInput, string whichPlayer)
		{
			if (playerInput.Contains("1") && playerInput.Contains("2") && playerInput.Contains("3"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("4") && playerInput.Contains("5") && playerInput.Contains("6"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("7") && playerInput.Contains("8") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("1") && playerInput.Contains("4") && playerInput.Contains("7"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("2") && playerInput.Contains("5") && playerInput.Contains("8"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("3") && playerInput.Contains("6") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("1") && playerInput.Contains("5") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
			if (playerInput.Contains("3") && playerInput.Contains("5") && playerInput.Contains("7"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
			}
		}
	}
}