using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public struct Size
    {

        public int Width { get; set; }

        public int Height { get; set; }

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Size(Point point)
        {
            Width = point.X;
            Height = point.Y;
        }

        public void Deconstruct(out int width, out int height)
        {
            width = Width;
            height = Height;
        }
    }
}
