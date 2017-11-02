using System;
using System.Collections.Generic;
using System.Text;

using Cosmos.System.Graphics;

using Kanga.Mouse;


namespace Kanga.Widget
{
    public class Control
    {

        //Properties
        public string Name
        {
            get; set;
        }

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

        //Events
        public event EventHandler<MouseEventArgs> OnClick;

        public event EventHandler Resize;
        public event EventHandler Move;
        public event EventHandler Paint;

        public void InvokeOnClick(object e, MouseEventArgs mouseEventArgs)
        {
            OnClick(e, mouseEventArgs);
        }

        public Control(string Name, Point Pos, Point Size)
        {
            
            this.Name = Name;
            this.Pos = Pos;
            this.Size = Size;

        }
        
        public virtual void Draw()
        {

            Paint(this, null);

        }

    }
}
