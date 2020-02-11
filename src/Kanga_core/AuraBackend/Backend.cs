using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Kanga_core.Drawing;

namespace Kanga_core.AuraBackend
{
    public class Backend : IBackend
    {
        private ConsoleColor[] screen;

        private List<Pixel> pixels = new List<Pixel>();

        private Point Size = new Point(Console.WindowWidth, Console.WindowHeight);

        //copyed from the net

        Color ToColor(ConsoleColor c)
        {
            int cInt = (int)c;

            int brightnessCoefficient = ((cInt & 8) > 0) ? 2 : 1;
            int r = ((cInt & 4) > 0) ? 64 * brightnessCoefficient : 0;
            int g = ((cInt & 2) > 0) ? 64 * brightnessCoefficient : 0;
            int b = ((cInt & 1) > 0) ? 64 * brightnessCoefficient : 0;

            return Color.FromArgb(r, g, b);
        }
        
        ConsoleColor FromColor(Color c)
        {
            int index = (c.R > 128 | c.G > 128 | c.B > 128) ? 8 : 0; // Bright bit
            index |= (c.R > 64) ? 4 : 0; // Red bit
            index |= (c.G > 64) ? 2 : 0; // Green bit
            index |= (c.B > 64) ? 1 : 0; // Blue bit
            return (System.ConsoleColor)index;
        }

        public void AddWindow(Window window)
        {
            return;
        }

        public Color GetPixel(int window, Point point)
        {
            return ToColor(screen[point.y * Size.x + point.x]);
        }

        public void Init()
        {

            screen = new ConsoleColor[Console.WindowWidth * Console.WindowHeight];


        }

        public void RemoveWindow(int window)
        {
            return;
        }

        public void RemoveWindow(Window window)
        {
            return;
        }

        public void Render()
        {
            for (int y = 0; y < Size.y; y++)
            {

                for (int x = 0; x < Size.x; x++)
                {



                }

            }
        }

        void TrueSet(Point point, ConsoleColor color)
        {

            Console.SetCursorPosition(point.x, point.y);

            screen[point.y * Size.x + point.x] = color;

            Console.BackgroundColor = screen[point.y * Size.x + point.x];

        }

        public void SetPixel(int window, Point point, Color color)
        {

            pixels.Add(new Pixel() { Point = point, Color = color});

            screen[point.y * Size.x + point.x] = FromColor(color);
        }

        public void SetPixel(int window, Pixel pixel)
        {
            throw new NotImplementedException();
        }

        public void SetImage(int window, Point point, Point Size, Image Image)
        {
            throw new NotImplementedException();
        }

        public void SetColorArrary(int window, Color[] data, Point point)
        {
            throw new NotImplementedException();
        }

        public void SetPixelArray(int window, Pixel[] data)
        {
            foreach (Pixel pixel in data)
                SetPixel(0, pixel);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
