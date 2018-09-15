using GameEngine;
using System;
using TicTacToeConsole;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            BaseGame game = new GameEngine.TicTacToe();
            Display console = new Display(game);

            console.PrintBoard();
            //TODO Implement game loop
            //TODO Gather user input

            Console.ReadLine();
        }
    }
}
