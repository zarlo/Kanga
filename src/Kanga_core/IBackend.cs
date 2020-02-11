using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Kanga_core
{
    public interface IBackend
    {

        void Init();

        void AddWindow(Window window);

        void RemoveWindow(int window);
        void RemoveWindow(Window window);

        void SetPixel(int window, Pixel pixel);
        Color GetPixel(int window, Point point);

        void SetPixel(Window window, Pixel pixel);
        Color GetPixel(Window window, Point point);

        void SetImage(int window, Point point, Drawing.Image Image);
        void SetImage(Window window, Point point, Drawing.Image Image);

        void SetColorArrary(int window, Color[] data, Point point);
        void SetPixelArray(int window, Pixel[] data);

        void Render();
        void Update();

    }
}
