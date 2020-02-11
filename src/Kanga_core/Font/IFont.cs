using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core.Font
{
    interface IFont
    {

        void LoadFromFile(string Path);
        void LoadFromArrary(byte[] data);
        void print(Window window, Point point, string text);

    }
}
