using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace WindowTest
{
    public class Game
    {
        GameWindow window;

        public Game(GameWindow window) {
            this.window = window;
            window.Title = "OpenTK Window Test";

            onStart();
        }

        void onStart()  {
            window.Load += load;
            window.RenderFrame += render;

            window.Run(1/60);
        }

        void render(object o, EventArgs e)  {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            window.SwapBuffers();
        }

        void load(object o, EventArgs e) {
            GL.ClearColor(0, 0, 0, 0);
        }
    }
}
