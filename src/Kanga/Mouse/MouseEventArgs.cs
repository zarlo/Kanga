using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

namespace Kanga.Mouse
{
    public class MouseEventArgs : EventArgs
    {


        public MouseEventArgs(MouseButtons Button, Point Location)
        {

            this.Button = Button;
            this.Location = Location;
            X = Location.X;
            Y = Location.Y;
            
        }

        public MouseButtons Button;

        public Point Location;

        public int X;
        public int Y;

    }
}
