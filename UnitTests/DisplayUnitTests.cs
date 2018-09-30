using GameEngine;
using Interfaces;
using System;
using TicTacToeConsole;
using Xunit;

namespace UnitTests
{
    public class DisplayUnitTests
    {
        [Fact]
        public void Winner_MinValue()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            char result = console.Winner();

            //Assert
            Assert.Equal(char.MinValue, result);
        }

        [Fact]
        public void Winner_XWins()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 2);

            char result = console.Winner();

            //Assert
            Assert.Equal('X', result);            
        }

        [Fact]
        public void Winner_OWins()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 1);
            game.PlaceMark(1, 0);
            game.PlaceMark(2, 0);

            char result = console.Winner();

            //Assert
            Assert.Equal('O', result);
        }

        [Fact]
        public void GameEndingMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
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
            BaseGame game = new GameEngine.TicTacToe(3, 3);
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
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            string result = console.GatherInputMessage();

            //Assert
            Assert.Equal(MessageEnums.Messages.GatherInput.GetDescription(), result);
        }

        [Fact]
        public void TitleMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            string result = console.Title();

            //Assert
            Assert.Equal(MessageEnums.Messages.Title.GetDescription(), result);
        }

        [Fact]
        public void ResultMessage()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            string result = console.Result();

            //Assert
            Assert.Equal(MessageEnums.Messages.Result.GetDescription() + Char.MinValue, result);
        }

        [Fact]
        public void ResultMessage_X()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 2);
            string result = console.Result();

            //Assert
            Assert.Equal(MessageEnums.Messages.Result.GetDescription() + "X", result);
        }

        [Fact]
        public void ResultMessage_O()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(2, 2);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 1);
            game.PlaceMark(1, 0);
            game.PlaceMark(2, 0);
            string result = console.Result();

            //Assert
            Assert.Equal(MessageEnums.Messages.Result.GetDescription() + "O", result);
        }

        [Fact]
        public void ResultMessage_Tie()
        {
            //Arrange
            BaseGame game = new GameEngine.TicTacToe(3, 3);
            IDisplay console = new Display(game);

            //Act
            /*             
                X | X | O
                O | O | X
                X | X | O
            */

            //Act
            game.PlaceMark(0, 0);
            game.PlaceMark(1, 1);
            game.PlaceMark(0, 1);
            game.PlaceMark(2, 2);
            game.PlaceMark(1, 2);
            game.PlaceMark(0, 2);
            game.PlaceMark(2, 0);
            game.PlaceMark(1, 0);
            game.PlaceMark(2, 1);
            string result = console.Result();

            //Assert
            Assert.Equal(MessageEnums.Messages.Result.GetDescription() + Char.MinValue, result);
        }
    }
}