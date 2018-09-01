using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public abstract class BaseGame : IGame
    {
        public char[,] Board 
        {
            get;
            set;
        } = new char[3,3];

        public bool IsXNext
        {
            get;
            set;
        }

        public abstract bool GameIsOver();

        public abstract bool PlaceMark(int x, int y);

        public abstract char Results();
    }
}
