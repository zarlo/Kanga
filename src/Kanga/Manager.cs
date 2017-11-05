using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

using Kanga.HAL;

namespace Kanga
{
    public class Manager
    {     

        static int activeDesktop = 0;
        static List<Window.Desktop> Desktop;

        public static void Init(Canvas Canvas = null)
        {
            if (Canvas == null)
            {

                GraphicsManager.Init(FullScreenCanvas.GetFullScreenCanvas());
                
            }
            else
            {

                GraphicsManager.Init(Canvas);

            }
                HALProxy.Mouse = new Cosmos.HAL.Mouse();
            HALProxy.Mouse.Initialize((uint) Canvas.Mode.Columns, (uint) Canvas.Mode.Rows);
            
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

            Desktop[Index].Windows.Add(window);

        }

        static void MouseTick()
        {

            foreach (Window.Window Windows in Desktop[activeDesktop].Windows)
            {

                if (Windows.WindowState == Window.WindowState.min)
                {

                    continue;

                }

                int Yi = Windows.Size.Y + Windows.Pos.Y;
                int Xi = Windows.Size.X + Windows.Pos.X;

                if (Windows.Pos.Y <= HALProxy.Mouse.Y && HALProxy.Mouse.Y <=  Yi)
                {

                    if (Windows.Pos.X <= HALProxy.Mouse.X && HALProxy.Mouse.X <= Xi)
                    {

                        foreach (Widget.Control Item in Windows.Controls)
                        {

                            int yi = Item.Size.Y + Item.Pos.Y;
                            int xi = Item.Size.X + Item.Pos.X;

                            if (Item.Pos.Y <= HALProxy.Mouse.Y && HALProxy.Mouse.Y <= yi)
                            {

                                if (Item.Pos.X <= HALProxy.Mouse.X && HALProxy.Mouse.X <= xi)
                                {

                                    if (HALProxy.Mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Left)
                                    {

                                        Item.InvokeOnClick(Item, new Kanga.Mouse.MouseEventArgs(Kanga.Mouse.MouseButtons.Left, new Point(HALProxy.Mouse.X, HALProxy.Mouse.Y)));

                                    }
                                    else if (HALProxy.Mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Right)
                                    {

                                        Item.InvokeOnClick(Item, new Kanga.Mouse.MouseEventArgs(Kanga.Mouse.MouseButtons.Right, new Point(HALProxy.Mouse.X, HALProxy.Mouse.Y)));

                                    }
                                    else if (HALProxy.Mouse.Buttons == Cosmos.HAL.Mouse.MouseState.Middle)
                                    {

                                        Item.InvokeOnClick(Item, new Kanga.Mouse.MouseEventArgs(Kanga.Mouse.MouseButtons.Middle, new Point(HALProxy.Mouse.X, HALProxy.Mouse.Y)));

                                    }

                                }

                            }

                        }

                    }

                }

            }

        }

        static void DrawTick()
        {

            foreach (Window.Window WI in Desktop[activeDesktop].Windows)
            {

                if (WI.WindowState == Window.WindowState.min)
                {
                    continue;
                }

                foreach (Widget.Control Item in WI.Controls)
                {

                    Item.Draw();

                }

                if (WI.WindowState == Window.WindowState.fullscreen)
                {

                    break;

                }

            }

        }

        public static void Tick()
        {

            MouseTick();
            DrawTick();
            
        }      


    }
}
