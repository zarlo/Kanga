using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

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

        public event EventHandler Resize;
        public event EventHandler Move;

        private Point pos;
        public Point Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
                Move(this, null);
            }
        }

        private Point size;
        public Point Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Resize(this, null);
            }
        }

        public WindowState WindowState
        {
            get; protected set;
        } = WindowState.windowed;

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
                        
            Manager.AddWindow(this);

            this.Move += ReDraw;
            this.Resize += ReDraw;

        }

        private void ReDraw(object sender, EventArgs e)
        {
            foreach (Widget.Control Item in Controls)
            {

                Item.Draw();

            }
        }

        public Window(int Index)
        {

            Manager.AddWindow(Index, this);

        }

        public Window(string DesktopName)
        {

            Manager.AddWindow(DesktopName, this);

        }

        public List<Widget.Control> Controls { get; protected set; } = new List<Widget.Control>();

    }
}
