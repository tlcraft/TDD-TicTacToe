using System;
using System.Collections.Generic;
using System.Linq;

namespace GameEngine
{
    public class TicTacToe : BaseGame
    {
        private readonly List<Coordinate[]> lines = new List<Coordinate[]>()
        {
            new Coordinate []
            {
                new Coordinate( 0, 0 ),
                new Coordinate( 1, 0 ),
                new Coordinate( 2, 0 ),
            },
            new Coordinate[]
            {
                new Coordinate( 0, 1 ),
                new Coordinate( 1, 1 ),
                new Coordinate( 2, 1 ),
            },
            new Coordinate[]
            {
                new Coordinate( 0, 2 ),
                new Coordinate( 1, 2 ),
                new Coordinate( 2, 2 ),
            },
            new Coordinate[]
            {
                new Coordinate( 0, 0 ),
                new Coordinate( 0, 1 ),
                new Coordinate( 0, 2 ),
            },
            new Coordinate[]
            {
                new Coordinate( 1, 0 ),
                new Coordinate( 1, 1 ),
                new Coordinate( 1, 2 ),
            },
            new Coordinate[]
            {
                new Coordinate( 2, 0 ),
                new Coordinate( 2, 1 ),
                new Coordinate( 2, 2 ),
            },
            new Coordinate[]
            {
                new Coordinate( 0, 0 ),
                new Coordinate( 1, 1 ),
                new Coordinate( 2, 2 ),
            },
             new Coordinate[]
            {
                new Coordinate( 0, 2 ),
                new Coordinate( 1, 1 ),
                new Coordinate( 2, 0 ),
            },
        };


        public override bool GameIsOver()
        {
            bool isFull = Board.Cast<char>().Where(s => s == Char.MinValue).Count() == 0;

            return isFull || IsWon();
        }

        public override bool IsWon()
        {
            bool isWon = false;
            
            foreach (Coordinate[] line in lines)
            {
                if (Board[line[0].x, line[0].y] != Char.MinValue 
                    && Board[line[0].x, line[0].y] == Board[line[1].x, line[1].y] 
                    && Board[line[0].x, line[0].y] == Board[line[2].x, line[2].y])
                {
                    isWon = true;
                    break;
                }
            }

            return isWon;
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

        private struct Coordinate
        {
            public int x, y;

            public Coordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
