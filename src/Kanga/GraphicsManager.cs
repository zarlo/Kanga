using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;

namespace Kanga
{
    public class GraphicsManager
    {

        internal static Color[] Buffer;
        internal static Color[] BackBuffer;

        internal static Canvas Canvas;

        internal static void Init(Canvas mCanvas)
        {

            Canvas = mCanvas;
            Reload();

        }

        internal static void Reload()
        {

            Buffer = new Color[Canvas.Mode.Columns * Canvas.Mode.Rows];

            for (int i = 0; i < Canvas.Mode.Columns * Canvas.Mode.Rows; i++)
            {

                Buffer[i] = Color.Black;

            }

            BackBuffer = Buffer;

        }


        /// <summary>
        /// Get the color from the buffer
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Color Get(int x, int y)
        {

            return BackBuffer[x + (y * Canvas.Mode.Rows)];

        }

        /// <summary>
        /// Adds a pixel to the buffer
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="c">Color</param>
        public static void Set(int x, int y, Color c)
        {

            if (x > Canvas.Mode.Columns)
            {
                throw new Exception("Set:x");
            }


            if (y > Canvas.Mode.Rows)
            {
                throw new Exception("Set:y");
            }

            Buffer[x + (y * Canvas.Mode.Rows)] = c;

        }

        internal static void Tick()
        {

            if (BackBuffer == Buffer)
                return;

            for (int x = 0; x < Canvas.Mode.Columns; x++)
            {
                for (int y = 0; y < Canvas.Mode.Rows; y++)
                {

                    if (Buffer[x] != BackBuffer[x])
                    {

                        Canvas.DrawPoint(new Pen(Buffer[x + (y * Canvas.Mode.Rows)]), x, y);

                        BackBuffer[x + (y * Canvas.Mode.Rows)] = Buffer[x + (y * Canvas.Mode.Rows)];

                    }

                }

            }

        }


    }
}
