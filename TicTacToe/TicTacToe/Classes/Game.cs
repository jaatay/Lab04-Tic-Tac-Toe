using System;
using System.Collections.Generic;
using System.Text;


namespace TicTacToe
{
	public class Game
	{
		/// <summary>
		/// method to check if there is a winner after every turn, converting the user arrays into strings for evaluation
		/// </summary>
		/// <param name="userOne">input parameter of user choice array for user one</param>
		/// <param name="userTwo">input parameter of user choice array for user two</param>
		
		public void CheckWinner(string[] userOne, string[] userTwo)
		{
			string userOneValues = String.Join("", userOne);
			string userTwoValues = String.Join("", userTwo);
			
			CheckOnePlayer(userOneValues, "One");
			CheckOnePlayer(userTwoValues, "Two");
		}

		/// <summary>
		/// method to check the user input strings against the winning conditions
		/// </summary>
		/// <param name="playerInput">string of user choices for player one</param>
		/// <param name="whichPlayer">string of user choices for player two</param>
		/// <returns>boolean value, returned to either continue while loop or exit</returns>
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