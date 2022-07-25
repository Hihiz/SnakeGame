using System;
using static System.Console;

namespace SnakeGame
{
    class Program
    {
        private const int MapWidth = 30;
        private const int MapHeight = 20;

        static void Main(string[] args)
        {
            SetWindowSize(MapWidth, MapHeight);
            SetBufferSize(MapWidth, MapHeight);
            CursorVisible = false;

            ReadKey();
        }
    }
}