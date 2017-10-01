using System;
using System.Collections.Generic;
using System.Text;

using Cosmos.System.Graphics;

using Kanga.Mouse;


namespace Kanga.Widget
{
    public class Control
    {

        public string Name
        {
            get; set;
        }

        public Point Pos
        {
            get; set;
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

        //Events
        public event EventHandler<MouseEventArgs> OnClick;
        public event EventHandler Resize;
        public event EventHandler<MouseEventArgs> OnClick;


        public Control(string Name, Point Pos, Point Size)
        {
            

            this.Name = Name;
            this.Pos = Pos;
            this.Size = Size;

        }
        

        public virtual void Tick()
        {
        }

    }
}
