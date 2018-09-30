namespace Interfaces
{
    public interface IDisplay
    {
        string GameStartMessage();
        string GameEndMessage();
        string GatherInputMessage();
        void PrintBoard();
        string Result();
        string Title();
        char Winner();
    }
}
