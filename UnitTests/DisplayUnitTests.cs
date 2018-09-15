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