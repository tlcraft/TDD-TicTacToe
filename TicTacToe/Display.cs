using GameEngine;
using Interfaces;
using System;

namespace TicTacToeConsole
{
    public class Display : IDisplay
    {
        public Display(BaseGame game)
        {
            Game = game;
        }

        private BaseGame Game
        {
            get;
            set;
        }

        public string GameEndMessage()
        {
            return MessageEnums.Messages.GameEnding.GetDescription();
        }

        public string GameStartMessage()
        {
            return MessageEnums.Messages.GameStart.GetDescription();
        }

        public string GatherInputMessage()
        {
            return MessageEnums.Messages.GatherInput.GetDescription();
        }

        public void PrintBoard()
        {
            int xLength = Game.Board.GetLength(0);
            int yLength = Game.Board.GetLength(1);

            for (int i = 0; i < xLength; i++)
            {
                for (int j = 0; j < yLength; j++)
                {
                    Console.Write(Game.Board[i, j]);

                    if (j != yLength-1)
                    {
                        Console.Write(" | ");
                    }
                }

                Console.WriteLine();
            }
        }

        public char Results()
        {
            char result = Char.MinValue;

            if (Game.GameIsOver())
            {
                result = !Game.IsXNext ? 'X' : 'O';
            }

            return result;
        }
    }
}
