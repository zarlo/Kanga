using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga.Window
{
    public class Desktop
    {

        static int _ID = -1;

        public int ID { get; private set; } = _ID++;

        public string Name
        {
            get; set;
        }

        public List<Window> Windows { get; protected set; } = new List<Window>();
        
    }
}
