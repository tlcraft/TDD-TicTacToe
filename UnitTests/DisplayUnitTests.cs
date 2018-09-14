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
            IDisplay console = new Display();

            //Act
            char result = console.Results(game);

            //Assert
            Assert.Equal(char.MinValue, result);
        }
    }
}