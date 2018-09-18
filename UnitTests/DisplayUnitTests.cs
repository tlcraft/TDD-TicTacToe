using GameEngine;
using Interfaces;
using TicTacToeConsole;
using Xunit;

namespace UnitTests
{
    public class DisplayUnitTests
    {
        [Fact]
        public void Results_MinValue()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            char result = console.Results();

            //Assert
            Assert.Equal(char.MinValue, result);
        }

        [Fact]
        public void Results_XWins()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 2);

            char result = console.Results();

            //Assert
            Assert.Equal('X', result);            
        }

        [Fact]
        public void Results_OWins()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 1);
            game.PlaceMark(1, 0);
            game.PlaceMark(2, 0);

            char result = console.Results();

            //Assert
            Assert.Equal('O', result);
        }

        [Fact]
        public void GameEndingMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            string result = console.GameEndMessage();

            //Assert
            Assert.Equal(MessageEnums.Messages.GameEnding.GetDescription(), result);
        }

        [Fact]
        public void GameStartMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            string result = console.GameStartMessage();

            //Assert
            Assert.Equal(MessageEnums.Messages.GameStart.GetDescription(), result);
        }

        [Fact]
        public void GatherInputMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe();
            IDisplay console = new Display(game);

            //Act
            string result = console.GatherInputMessage();

            //Assert
            Assert.Equal(MessageEnums.Messages.GatherInput.GetDescription(), result);
        }
    }
}