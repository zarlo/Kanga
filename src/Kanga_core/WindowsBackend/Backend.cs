using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using SharpDX;

using Kanga_core.Drawing;
using SharpDX.Direct2D1;
using Color = System.Drawing.Color;

namespace Kanga_core.WindowsBackend
{

    public class Backend : IBackend
    {
        private DeviceContext d2dContext;

        public void Init()
        {

            SharpDX.Direct2D1.Device d2dDevice = new SharpDX.Direct2D1.Device(dxgiDevice2);
            d2dContext = new SharpDX.Direct2D1.DeviceContext(d2dDevice, SharpDX.Direct2D1.DeviceContextOptions.None);

        }

        public void AddWindow(Window window)
        {
            throw new NotImplementedException();
        }

        public System.Drawing.Color GetPixel(int window, Kanga_core.Point point)
        {
            throw new NotImplementedException();
        }

        public void RemoveWindow(int window)
        {
            throw new NotImplementedException();
        }

        public void RemoveWindow(Window window)
        {
            throw new NotImplementedException();
        }

        public void SetPixel(int window, Kanga_core.Point point, Color color)
        {
            throw new NotImplementedException();
        }

        public void SetPixelArray(int window, Kanga_core.Point point, int width, int high, Color[] data)
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void SetPixel(int window, Pixel pixel)
        {
            throw new NotImplementedException();
        }

        public void SetImage(int window, Point point, Point Size, Drawing.Image Image)
        {
            throw new NotImplementedException();
        }

        public void SetPixelArray(int window, Pixel[] data, Point point)
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
