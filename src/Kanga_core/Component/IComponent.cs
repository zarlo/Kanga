using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core.Component
{
    public class IComponent
    {

        public Window Perent;

        public IComponent()
        {

            Perent.AddComponent(this);

        }

        public string Name { set; get; }
        public string Text { set; get; }

        public Point Point { set; get; }
        public Point Size { set; get; }

        public virtual void Render() { }

        public virtual void Resize() { }


        public virtual void OnClick(Point point, MouseButton mouseButton) { }

        public event EventHandler<MouseEventArgs> OnClickEvent;


    }
}
