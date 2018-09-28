using Interfaces;
using Xunit;

namespace UnitTests
{
    public class GameEngineUnitTests
    {
        [Fact]
        public void GameIsOver_False()
        {
            //Arrange
            IGame game = new GameEngine.TicTacToe();

            //Act
            bool isOver = game.GameIsOver();

            //Assert
            Assert.False(isOver, "The game should not be over because nothing has happened yet.");
        }

        [Fact]
        public void GameIsOver_IsWon_True()
        {
            //Arrange
            IGame game = new GameEngine.TicTacToe();

            /*             
                 X | X | X
                   | O |  
                   |   | O
           */

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 2);

            bool isOver = game.GameIsOver();

            //Assert
            Assert.True(isOver, "The game should be over because X has won.");
        }

        [Fact]
        public void IsWon_True()
        {
            //Arrange
            IGame game = new GameEngine.TicTacToe();

            /*             
                 X | X | X
                   | O |  
                   |   | O
           */

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 2);

            bool isOver = game.IsWon();

            //Assert
            Assert.True(isOver, "The game should be over because X has won.");
        }

        [Fact]
        public void IsWon_False()
        {
            //Arrange
            IGame game = new GameEngine.TicTacToe();
                       
            //Act
            bool isOver = game.IsWon();

            //Assert
            Assert.False(isOver, "The game should not be over because nothing has happened.");
        }

        [Fact]
        public void GameIsOver_IsFull_True()
        {
            //Arrange
            IGame game = new GameEngine.TicTacToe();

            /*             
                  X | O | X
                  X | X | O
                  O | X | O
            */

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(1, 0);
            game.PlaceMark(2, 0);
            game.PlaceMark(2, 1);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 2);
            game.PlaceMark(1, 2);

            bool isOver = game.GameIsOver();

            //Assert
            Assert.True(isOver, "The game should be over because X has won.");
        }

        [Fact]
        public void PlaceMark_OnGrid()
        {
            IGame game = new GameEngine.TicTacToe();

            bool success = game.PlaceMark(1, 1);

            Assert.True(success, "The mark would be placed on the board.");
        }

        [Fact]
        public void PlaceMark_OffGrid()
        {
            IGame game = new GameEngine.TicTacToe();

            bool success = game.PlaceMark(-1, -1);

            Assert.False(success, "The mark would not be placed on the board.");
        }

        [Fact]
        public void PlaceMark_AlreadyUsedLocation()
        {
            IGame game = new GameEngine.TicTacToe();
            game.PlaceMark(1, 1);
            bool success = game.PlaceMark(1, 1);

            Assert.False(success, "The mark would not be placed on the board.");
        }
    }
}
