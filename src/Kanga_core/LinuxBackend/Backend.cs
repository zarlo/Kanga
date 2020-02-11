using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Kanga_core.Drawing;

using SFML.Graphics;
using SFML.Window;
using Color = System.Drawing.Color;
using Image = Kanga_core.Drawing.Image;

namespace Kanga_core.LinuxBackend
{
    public class Backend : IBackend
    {

        Dictionary<Window, RenderWindow> RenderWindow = new Dictionary<Window, RenderWindow>();

        public void AddWindow(Window window)
        {

            RenderWindow RW = new RenderWindow(new VideoMode((uint)window.Size.x, (uint)window.Size.y, VideoMode.DesktopMode.BitsPerPixel), window.Title);

            RenderWindow.Add(window, RW);
            

        }

        public Color GetPixel(int window, Point point)
        {
            throw new NotImplementedException();
        }

        public Color GetPixel(Window window, Point point)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void RemoveWindow(int window)
        {

            RemoveWindow(RenderWindow.ElementAt(window).Key);
            
        }

        public void RemoveWindow(Window window)
        {

            RenderWindow[window].Close();
            RenderWindow[window] = null;

        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void SetColorArrary(int window, Color[] data, Point point)
        {
            throw new NotImplementedException();
        }

        public void SetImage(int window, Point point, Drawing.Image Image)
        {

            SetImage(RenderWindow.ElementAt(window).Key, point, Image);

        }

        public void SetImage(Window window, Point point, Image Image)
        {

            //RenderWindow[window].Draw();

        }

        public void SetPixel(int window, Pixel pixel)
        {
            throw new NotImplementedException();
        }

        public void SetPixel(Window window, Pixel pixel)
        {
            throw new NotImplementedException();
        }

        public void SetPixelArray(int window, Pixel[] data)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        System.Drawing.Color IBackend.GetPixel(int window, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
