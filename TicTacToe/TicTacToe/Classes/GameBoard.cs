using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe{

	public class GameBoard
	{
		/// <summary>
		/// property of GameBoard class, containing 2d array for game board.
		/// </summary>
		public string[,] NewBoard = {
									{ "1", "2", "3" },
									{ "4", "5", "6" },
									{ "7", "8", "9" }
									};

		/// <summary>
		/// method to draw the initial game board
		/// </summary>
		/// <param name="inputArray">input 2d array to draw board</param>
		public void DrawBoard(string[,] inputArray)
		{
			for(int i = 0; i < inputArray.GetLength(0); i++)
			{
				for(int j = 0; j < inputArray.GetLength(1); j++)
				{
					Console.Write($"|{inputArray[i, j]}|");
				}
				Console.WriteLine("");
			}
		}

		/// <summary>
		/// method to update positions on the board
		/// </summary>
		/// <param name="playerOneInput">string type array of user one choices</param>
		/// <param name="playerTwoInput">string type array of user two choices</param>
		/// <param name="inputArray">2d array used to draw updated game board</param>
		/// <param name="playerOneMarker">string of X for player one</param>
		/// <param name="playerTwoMarker">string of O for player two</param>
		public void UpdatePositions(string[] playerOneInput, string[] playerTwoInput, string[,] inputArray, string playerOneMarker, string playerTwoMarker)
		{

			foreach (string item in playerOneInput)
			{
				for (int i = 0; i < inputArray.GetLength(0); i++)
				{
					for (int j = 0; j < inputArray.GetLength(1); j++)
					{
						if (inputArray[i, j].Contains(item))
						{
							inputArray[i, j] = playerOneMarker;
		
						}
						
					}
					
				}
			}

			foreach (string item in playerTwoInput)
			{
				for (int i = 0; i < inputArray.GetLength(0); i++)
				{
					for (int j = 0; j < inputArray.GetLength(1); j++)
					{
						if (inputArray[i, j].Contains(item))
						{
							inputArray[i, j] = playerTwoMarker;
						}

					}

				}
			}

			for (int i = 0; i < inputArray.GetLength(0); i++)
			{
				for (int j = 0; j < inputArray.GetLength(1); j++)
				{
					Console.Write($"|{inputArray[i, j]}|");
				}
				Console.WriteLine("");
			}
		}
	
	}
}


