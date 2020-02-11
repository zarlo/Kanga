using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core
{

    public enum MouseButton
    {

        Left = 0,
        Right = 1,
        Middle = 2

    }

    public class MouseEventArgs : EventArgs
    {

        public Mouse Mouse { get; set; }
        
    }

    public class Mouse
    {
                     
        public MouseButton Button;

        public Point Point;

        public Mouse(Point Point, MouseButton Button)
        {

            this.Point = Point;
            this.Button = Button;

        }

    }
}
