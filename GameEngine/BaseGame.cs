using Interfaces;

namespace GameEngine
{
    public abstract class BaseGame : IGame
    {
        public BaseGame(int x, int y)
        {
            Board = new char[x, y];
        }

        public char[,] Board 
        {
            get;
        }

        public bool IsXNext
        {
            get;
            set;
        } = true;

        public abstract bool IsWon();
        public abstract bool GameIsOver();
        public abstract bool PlaceMark(int x, int y);
    }
}
