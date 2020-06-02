using System;
using OpenTK;

namespace WindowTest
{
    class MainClass {
        static GameWindow window;
        static Game game;

        public static void Main(string[] args)
        {
            window = new GameWindow(1000, 750);
            game = new Game(window);
        }
    }
}
