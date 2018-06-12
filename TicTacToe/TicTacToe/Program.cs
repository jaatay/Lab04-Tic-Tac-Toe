using System;

namespace TicTacToe
{
	class Program
	{

		static void Main(string[] args)
		{
			InitializeGame();
	
		}

		//global value types
		public static string playerOneName;
		public static string playerTwoName;
		public static string playerOneChoices = "";
		public static string playerTwoChoices = "";
		public static bool playGame = true;
		public static bool playerOneTurn = true;
		public static bool playerTwoTurn = false;

		/// <summary>
		/// method to initialize the game
		/// </summary>
		public static void InitializeGame()
		{
		CreatePeople();
		WelcomeMessage();
		while (playGame)
		{
			WhoseTurnIsIt();
		}
		PlayAgain();
		}
		
		/// <summary>
		/// method to create new users, assign user input to name variable
		/// </summary>
		public static void CreatePeople() {
			Console.Clear();
			GameBoard NewGame = new GameBoard();
			Game CheckGame = new Game();
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
		
		/// <summary>
		/// method to tell users who is X and who is O, draws initial board
		/// </summary>
		public static void WelcomeMessage()
		{
			Console.Clear();
			GameBoard NewGame = new GameBoard();
			NewGame.DrawBoard(NewGame.NewBoard);
			Console.WriteLine($"{playerOneName} is X.");
			Console.WriteLine($"{playerTwoName} is O.");
			Console.WriteLine("Press any key to begin.");
			Console.ReadLine();
		}

		/// <summary>
		/// method to switch between users, taking user input and sending info to update board, check against winning conditions
		/// </summary>
		public static void WhoseTurnIsIt()
		{
			GameBoard NewGame = new GameBoard();
			Game CheckGame = new Game();

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

				if (playerOneChoices.Length == 5)
				{
					Console.WriteLine("The game is a draw!");
					Console.ReadLine();

					playGame = false;
					playerTwoTurn = false;
				}

				NewGame.UpdatePositions(playerOneArray, playerTwoArray, NewGame.NewBoard, "X", "O");
				CheckGame.CheckWinner(playerOneArray, playerTwoArray);
				Console.WriteLine("Press any key to continue.");
				Console.ReadLine();

				if (playerOneChoices.Length == 5)
				{
					Console.WriteLine("The game is a draw!");
					playGame = false;
					playerTwoTurn = false;
				}

				if (playGame)
				{
					if (playerOneChoices.Length == 5)
					{
						Console.WriteLine("The game is a draw!");
						Console.ReadLine();
						playGame = false;
						playerTwoTurn = false;
					}

					playerTwoTurn = true;
					playerOneTurn = false;
				}
				
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
				Console.WriteLine("Press any key to continue.");
				Console.ReadLine();

				if (playGame)
				{
					
					playerTwoTurn = false;
					playerOneTurn = true;
				}
			}
		}

		/// <summary>
		/// method to choose position on the board based on user input. 
		/// </summary>
		
		public static string ChoosePosition()
		{
			try
			{
				string newPosition = Console.ReadLine();
				Int32.TryParse(newPosition, out int newPositionInt);
				if (newPosition == "" || newPosition == null || newPositionInt > 9 || newPositionInt < 1 )
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

		/// <summary>
		/// method to ask if the user wants to play again after the game is finished. If so, it initializes another game. If not, exit program.
		/// </summary>
		public static void PlayAgain()
		{
			Console.Clear();
			Console.WriteLine("Play another game?");
			Console.WriteLine("1. Yes");
			Console.WriteLine("2. No");

			try
			{
				string playerChoice = Console.ReadLine();

				if (playerChoice == "1")
				{
					playGame = true;
					playerOneChoices = "";
					playerTwoChoices = "";
					InitializeGame();
				}

				playGame = false;
				Console.WriteLine("Press any key to exit.");

			}
			catch(Exception)
			{
				Console.WriteLine("Please enter a valid input.");
			}
			
			
		}

	}
}
