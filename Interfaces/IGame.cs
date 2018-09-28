namespace Interfaces
{
    public interface IGame
    {
        bool PlaceMark(int x, int y);
        bool IsWon();
        bool GameIsOver();
    }
}
