using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga
{
    public class GraphicsManager
    {

        internal byte[] Buffer;
        internal byte[] BackBuffer;

        internal Cosmos.System.Graphics.Canvas Canvas;

        internal void Reload()
        {

            Buffer = new byte[Canvas.Mode.Columns * Canvas.Mode.Rows];

            for (int i = 0; i < Canvas.Mode.Columns * Canvas.Mode.Rows; i++)
            {

                Buffer[i] = 0;

            }

            BackBuffer = Buffer;

        }

    }
}
