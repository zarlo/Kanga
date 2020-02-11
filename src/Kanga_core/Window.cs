using Kanga_core.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core
{
    public class Window
    {

        private List<IComponent> Components = new List<IComponent>();

        public Point Size;

        public string Title;

        public int ID;

        public Window(Point Size)
        {

            this.Size = Size;

            Kanga.Backend.AddWindow(this);

        }

        public void Close()
        {

            Kanga.Backend.RemoveWindow(this);

        }

        public void Render()
        {

            foreach (IComponent Item in Components)
            {
                Item.Render();
            }

        }

        public void AddComponent(IComponent Component)
        {

            Component.Perent = this;
            Component.Render();
            Components.Add(Component);

        }


    }
}
