using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga_core.Drawing
{
    public class Image
    {

        public Point Size;


        public static Image LoadFromFile(string path)
        {

            byte[] FileData = System.IO.File.ReadAllBytes(path);


            uint offset = BitConverter.ToUInt32(FileData, 10);



            return new Image();

        }

    }
}
