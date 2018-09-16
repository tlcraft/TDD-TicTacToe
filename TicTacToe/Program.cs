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

            Console.WriteLine(console.GameStartMessage());

            int[] coordinates = new int[2];

            while (!game.GameIsOver())
            {
                console.PrintBoard();
                Console.WriteLine(console.GatherInputMessage());
                coordinates = GatherInput();

                game.PlaceMark(coordinates[0], coordinates[1]);
            }

            Console.WriteLine(console.GameEndMessage());
            console.PrintBoard();
            Console.WriteLine("The wiiner is: " + console.Results());
            Console.ReadLine();
        }

        public static int[] GatherInput()
        {
            int[] coordinates = new int[2];
            string input;
            int selection;
            bool complete = false;

            while (!complete)
            {
                coordinates = new int[2];
                input = Console.ReadLine();

                string[] pieces = input.Split(",");

                if (pieces.Length != coordinates.Length)
                {
                    Console.WriteLine(MessageEnums.Errors.InputError.GetDescription());
                }
                else
                {
                    for (int i = 0; i < pieces.Length; i++)
                    {
                        if (!Int32.TryParse(pieces[i].Trim(), out selection))
                        {
                            selection = -1;
                        }

                        if (selection > coordinates.Length || selection < 0)
                        {
                            Console.WriteLine(MessageEnums.Errors.InputError.GetDescription());
                            complete = false;
                            break;
                        }
                        else
                        {
                            coordinates[i] = selection;
                            complete = true;
                        }
                    }
                }
            }

            return coordinates;
        }
    }
}
