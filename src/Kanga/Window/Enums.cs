using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga.Window
{
    public enum WindowState
    {

        fullscreen = 0x01,
        min = 0x02,
        max = 0x03,
        windowed = 0x04,

    }

    public enum BorderStyle
    {

        None = 0x00,
        Fixed3D = 0x10,
        FixedDialog = 0x11,
        FixedSingle = 0x12,
        FixedToolWindow = 0x13,
        Sizable = 0x20,
        SizableToolWindow = 0x21

    }

}
