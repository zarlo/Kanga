using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

namespace Kanga
{
    public class Manger
    {

        static Canvas Canvas;

        static Cosmos.HAL.Mouse Mouse;

        public static int activeDesktop = 0;
        static List<Window.Desktop> Desktop;

        public static void Init()
        {

            Canvas = FullScreenCanvas.GetFullScreenCanvas();
            Mouse = new Cosmos.HAL.Mouse();
            Mouse.Initialize((uint) Canvas.Mode.Columns, (uint) Canvas.Mode.Rows);

            Desktop = new List<Window.Desktop>();
            Desktop.Add(new Window.Desktop() { Name = "Main"});
            

        }

        public static void AddWindow(Window.Window window)
        {

            AddWindow(activeDesktop, window);

        }

        public static void AddWindow(string Name, Window.Window window)
        {

            for (int i = 0; i < Desktop.Count; i++)
            {
                if (Desktop[i].Name == Name)
                {

                    AddWindow(i, window);
                    break;

                }
            }

        }

        public static void AddWindow(int Index, Window.Window window)
        {

            Desktop[activeDesktop].Windows.Add(window);

        }

        public static void MouseTick()
        {

            if (Mouse.Buttons != Cosmos.HAL.Mouse.MouseState.None)
            {

            }

        }

        public static void Tick()
        {
            


        }

        


    }
}
