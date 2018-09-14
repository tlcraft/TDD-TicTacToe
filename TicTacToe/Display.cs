using GameEngine;
using Interfaces;
using System;

namespace TicTacToeConsole
{
    public class Display : IDisplay
    {
        public void PrintBoard(IGame game)
        {
            //TODO Remove all this casting!!
            for (int i = 0; i < ((BaseGame)game).Board.GetLength(0); i++)
            {
                for (int j = 0; j < ((BaseGame)game).Board.GetLength(1); j++)
                {
                    Console.Write(((BaseGame)game).Board[i, j]);
                }

                Console.WriteLine();
            }
        }

        public char Results(IGame game)
        {
            char result = Char.MinValue;

            if (game.GameIsOver())
            {
                result = !((BaseGame)game).IsXNext ? 'O' : 'X';
            }

            return result;
        }
    }
}
