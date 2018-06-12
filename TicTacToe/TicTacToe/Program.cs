using System;

namespace TicTacToe
{
	class Program
	{

		static void Main(string[] args)
		{

			CreatePeople();
			WelcomeMessage();
			while (playGame)
			{
				WhoseTurnIsIt();
			}
			
		}

		//global reference types
		public static GameBoard NewGame = new GameBoard();
		public static Game CheckGame = new Game();

		//global value types
		public static string playerOneName;
		public static string playerTwoName;
		public static string playerOneChoices = "";
		public static string playerTwoChoices = "";
		public static bool playGame = true;
		public static bool playerOneTurn = true;
		public static bool playerTwoTurn = false;

		//initialize game
		
		public static void CreatePeople() {
			Console.Clear();
			NewGame.DrawBoard(NewGame.NewBoard);
			Person playerOne = new Person();
			Person playerTwo = new Person();

			playerOne.playerMark = "X";
			playerTwo.playerMark = "O";

			Console.WriteLine("Player One, please enter your name.");
			try
			{
				playerOneName = Console.ReadLine();
				if(playerOneName == "" || playerOneName == null)
				{
					throw new FormatException();
				}
				
			}
			catch (FormatException)
			{
				Console.WriteLine("Please enter valid input.");
			}

			Console.WriteLine("Player Two, please enter your name.");
			try
			{
				playerTwoName = Console.ReadLine();
				if (playerTwoName == "" || playerTwoName == null)
				{
					throw new FormatException();
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Please enter valid input.");
			}
		}
		
		public static void WelcomeMessage()
		{
			Console.Clear();
			NewGame.DrawBoard(NewGame.NewBoard);
			Console.WriteLine($"{playerOneName} is X.");
			Console.WriteLine($"{playerTwoName} is O.");
			Console.WriteLine("Press any key to begin.");
			Console.ReadLine();
		}

		public static void WhoseTurnIsIt()
		{
			if (playerOneTurn)
			{

				Console.WriteLine($"{playerOneName}, choose your position.");
				playerOneChoices += ChoosePosition();

				char[] playerOne = playerOneChoices.ToCharArray();
				char[] playerTwo = playerTwoChoices.ToCharArray();

				string[] playerOneArray = new string[playerOne.Length];
				string[] playerTwoArray = new string[playerTwo.Length];

				for(int i = 0; i < playerOne.Length; i++)
				{
					playerOneArray[i] = playerOne[i].ToString();
				}

				for(int j = 0; j < playerTwo.Length; j++)
				{
					playerTwoArray[j] = playerTwo[j].ToString();
				}

				Console.Clear();
				NewGame.UpdatePositions(playerOneArray, playerTwoArray, NewGame.NewBoard, "X", "O");
				CheckGame.CheckWinner(playerOneArray, playerTwoArray);

				playerTwoTurn = true;
				playerOneTurn = false;
			}

			if (playerTwoTurn)
			{
			
				Console.WriteLine($"{playerTwoName}, choose your postion.");
				playerTwoChoices += ChoosePosition();

				char[] playerOne = playerOneChoices.ToCharArray();
				char[] playerTwo = playerTwoChoices.ToCharArray();

				string[] playerOneArray = new string[playerOne.Length];
				string[] playerTwoArray = new string[playerTwo.Length];

				for (int i = 0; i < playerOne.Length; i++)
				{
					playerOneArray[i] = playerOne[i].ToString();
				}

				for (int j = 0; j < playerTwo.Length; j++)
				{
					playerTwoArray[j] = playerTwo[j].ToString();
				}

				Console.Clear();
				NewGame.UpdatePositions(playerOneArray, playerTwoArray, NewGame.NewBoard, "X", "O");
				CheckGame.CheckWinner(playerOneArray, playerTwoArray);

				playerTwoTurn = false;
				playerOneTurn = true;
			}
		}

		public static string ChoosePosition()
		{
			try
			{
				string newPosition = Console.ReadLine();
				if (newPosition == "" || newPosition == null)
				{
					throw new FormatException();
				}

				return newPosition;
			}
			catch (FormatException)
			{
				Console.WriteLine("Please enter a valid choice.");
			}

			return "";
		}

	}
}
