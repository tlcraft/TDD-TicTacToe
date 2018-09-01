using System;
using Xunit;
using GameEngine;
using Interfaces;

namespace UnitTests
{
    public class GameEngineUnitTests
    {
        [Fact]
        public void GameIsOver_False()
        {
            //Arrange
            IGame game = new TicTacToe();

            //Act
            bool isOver = game.GameIsOver();

            //Assert
            Assert.True(isOver, "The game should not be over because nothing has happened yet.");
        }

        [Fact]
        public void GameIsOver_True()
        {
            //Arrange
            IGame game = new TicTacToe();

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
        public void PlaceMark_OnGrid()
        {
            IGame game = new TicTacToe();

            bool success = game.PlaceMark(1, 1);

            Assert.True(success, "The mark would be placed on the board.");
        }

        [Fact]
        public void PlaceMark_OffGrid()
        {
            IGame game = new TicTacToe();

            bool success = game.PlaceMark(-1, -1);

            Assert.False(success, "The mark would not be placed on the board.");
        }

        [Fact]
        public void PlaceMark_AlreadyUsedLocation()
        {
            IGame game = new TicTacToe();
            game.PlaceMark(1, 1);
            bool success = game.PlaceMark(1, 1);

            Assert.False(success, "The mark would not be placed on the board.");
        }
    }
}