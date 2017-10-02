using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga.Window
{
    public class Window
    {

        public int DesktopID
        {
            get; protected set;
        }

        public string Name
        {
            get; protected set;
        }

        public int Width
        {
            get; protected set;
        }

        public int Height
        {
            get; protected set;
        }

        public BorderStyle BorderStyle
        {
            get; protected set;
        } = BorderStyle.Sizable;

        public int zIndex
        {
            get; set;
        }

        public Window()
        {

            DesktopID = Manger.activeDesktop;

            Manger.AddWindow(DesktopID, this);

        }

        public Window(string Name)
        {

            Manger.AddWindow(Name,this);

        }

        public List<Widget.Control> Controls { get; protected set; } = new List<Widget.Control>();

    }
}
