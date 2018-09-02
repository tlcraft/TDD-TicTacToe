using System;
using Interfaces;
using GameEngine;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            IGame game = new GameEngine.TicTacToe();
            //TODO Implement game loop
            //TODO Gather user input
        }
        
        // TODO Move to a display class
        public char Results(BaseGame game)
        {
            char result = Char.MinValue;

            if (game.GameIsOver())
            {
                result = !game.IsXNext ? 'O' : 'X';
            }

            return result;
        }
    }
}
