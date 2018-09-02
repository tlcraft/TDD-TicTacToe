using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGame
    {
        bool PlaceMark(int x, int y);

        bool GameIsOver();
    }
}
