using System;
using Xunit;
using TicTacToe;

namespace TicTacTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanWin()
        {
			Game thisGame = new Game();
			string userString = "123";
			Assert.True(thisGame.CheckOnePlayer(userString, "One"));
        }

		[Fact]
		public void CanWin2()
		{
			Game thisGame = new Game();
			string userString = "147";
			Assert.True(thisGame.CheckOnePlayer(userString, "One"));
		}

		[Fact]
		public void CanWin3()
		{
			Game thisGame = new Game();
			string userString = "159";
			Assert.True(thisGame.CheckOnePlayer(userString, "One"));
		}


	}
}
