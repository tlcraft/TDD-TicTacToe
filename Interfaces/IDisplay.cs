namespace Interfaces
{
    public interface IDisplay
    {
        void PrintBoard();
        char Results();
        string GameStartMessage();
        string GameEndMessage();
        string GatherInputMessage();
    }
}
