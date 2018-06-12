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
			

			CheckOnePlayer(userOneValues, "One");
			CheckOnePlayer(userTwoValues, "Two");

			return "";
		}

		public bool CheckOnePlayer(string playerInput, string whichPlayer)
		{
			if (playerInput.Contains("1") && playerInput.Contains("2") && playerInput.Contains("3"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("4") && playerInput.Contains("5") && playerInput.Contains("6"))
			{
				
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false; 
			}
			if (playerInput.Contains("7") && playerInput.Contains("8") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("1") && playerInput.Contains("4") && playerInput.Contains("7"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("2") && playerInput.Contains("5") && playerInput.Contains("8"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("3") && playerInput.Contains("6") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("1") && playerInput.Contains("5") && playerInput.Contains("9"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}
			if (playerInput.Contains("3") && playerInput.Contains("5") && playerInput.Contains("7"))
			{
				Console.WriteLine($"Player {whichPlayer} wins!");
				Program.playGame = false;
			}

			return false;
		}
	}
}