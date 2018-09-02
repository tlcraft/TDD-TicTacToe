using System;
using System.Linq;
using Interfaces;

namespace GameEngine
{
    public class TicTacToe : BaseGame
    {
        public override bool GameIsOver()
        {
            bool isFull = Board.Cast<char>().Where(s => s == Char.MinValue).Count() == 0;

            return isFull || IsWon();
        }

        public bool IsWon()
        {
            //TODO Complete implementation
            return false;
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
    }
}
