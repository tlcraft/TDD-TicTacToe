using System;
using Interfaces;

namespace GameEngine
{
    public class TicTacToe : BaseGame
    {
        public override bool GameIsOver()
        {
            throw new NotImplementedException();
        }

        public override bool PlaceMark(int x, int y)
        {
            bool success = false;

            if (x < 0
                || x > Board.GetLength(0)
                || y < 0
                || y > Board.GetLength(1))
                return success;

            if (Board[x, y] == Char.MinValue)
            {
                Board[x, y] = IsXNext ? 'X' : 'O';
                IsXNext = !IsXNext;
                success = true;
            }

            return success;
        }

        public override char Results()
        {
            char result = Char.MinValue;

            if (GameIsOver())
            {
                result = !IsXNext ? 'O' : 'X';
            }

            return result;
        }
    }
}
