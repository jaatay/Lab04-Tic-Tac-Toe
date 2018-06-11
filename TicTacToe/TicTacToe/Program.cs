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
			CheckGame.CheckWinner(playerOneChoices, playerTwoChoices);
			
        }

		
		public static GameBoard NewGame = new GameBoard();
		public static Game CheckGame = new Game();
		
		
		public static string[] playerOneChoices = { "2", "3", "6" };
		public static string[] playerTwoChoices = {"1", "5", "9" };




	}
}
