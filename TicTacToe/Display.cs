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
            for (int i = 0; i < Game.Board.GetLength(0); i++)
            {
                for (int j = 0; j < Game.Board.GetLength(1); j++)
                {
                    Console.Write(Game.Board[i, j]);
                }

                Console.WriteLine();
            }
        }

        public char Results()
        {
            char result = Char.MinValue;

            if (Game.GameIsOver())
            {
                result = !Game.IsXNext ? 'O' : 'X';
            }

            return result;
        }
    }
}
