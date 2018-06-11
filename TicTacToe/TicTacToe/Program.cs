using System;

namespace TicTacToe
{
    class Program
    {
		
		static void Main(string[] args)
        {
			
			Console.WriteLine("Hello World!");
			NewGame.WelcomeMessage();
			NewGame.DrawBoard(NewGame.NewBoard);
			Console.WriteLine("");
			NewGame.UpdatePositions(playerOneChoices, playerTwoChoices, NewGame.NewBoard, "X", "O");
			
        }


		 public static GameBoard NewGame = new GameBoard();
		public static string[] playerOneChoices = { "3", "5" };
		public static string[] playerTwoChoices = {"1", "7", "9" };




	}
}
