using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe{

	public class GameBoard
	{
		public void WelcomeMessage()
		{
			Console.WriteLine("I am here now");
			
		}

		public string[,] NewBoard = {
									{ "1", "2", "3" },
									{ "4", "5", "6" },
									{ "7", "8", "9" }
									};

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


