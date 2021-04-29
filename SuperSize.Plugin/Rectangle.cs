using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public struct Rectangle
    {

        private Point _point;
        private Size _size;

        public Rectangle(Point point, Size size)
        {
            _point = point;
            _size = size;
        }

        public Rectangle(int x, int y, int width, int height)
        {
            _point = new(x, y);
            _size = new(width, height);
        }

        public Point Point
        {
            get => _point;
            set => _point = value;
        }

        public Size Size
        {
            get => _size;
            set => _size = value;
        }

        public int X
        {
            get => _point.X;
            set => _point.X = value;
        }

        public int Y
        {
            get => _point.Y;
            set => _point.Y = value;
        }

        public int Width
        {
            get => _size.Width;
            set => _size.Width = value;
        }

        public int Height
        {
            get => _size.Height;
            set => _size.Height = value;
        }

        public void Deconstruct(out Point point, out Size size)
        {
            point = Point;
            size = Size;
        }

        public void Deconstruct(out int x, out int y, out int width, out int height)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
        }
    }
}
