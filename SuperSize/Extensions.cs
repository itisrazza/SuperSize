using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SuperSize
{
    public static class Extensions
    {

        public static void Deconstruct(this Size size, out int width, out int height)
        {
            width = size.Width;
            height = size.Height;
        }

        public static void Deconstruct(this Rectangle rectangle, out int x, out int y, out int width, out int height)
        {
            x = rectangle.X;
            y = rectangle.Y;
            width = rectangle.Width;
            height = rectangle.Height;
        }

        /// <summary>
        /// Creates a Win32 (GDI+) point from the Plugin API.
        /// </summary>
        public static Point ToWin32(this Plugin.Point point)
            => new(point.X, point.Y);

        /// <summary>
        /// Creates a Plugin API point from Win32 (GDI+).
        /// </summary>
        public static Plugin.Point ToPlugin(this Point point)
            => new(point.X, point.Y);

        /// <summary>
        /// Creates a Win32 (GDI+) size from the Plugin API.
        /// </summary>
        public static Size ToWin32(this Plugin.Size size)
            => new(size.Width, size.Height);

        /// <summary>
        /// Creates a Plugin API size from Win32 (GDI+).
        /// </summary>
        public static Plugin.Size ToPlugin(Size size)
            => new(size.Width, size.Height);

        /// <summary>
        /// Creates a Win32 (GDI+) rectangle from the Plugin API.
        /// </summary>
        public static Rectangle ToWin32(this Plugin.Rectangle rect)
            => new(rect.Point.ToWin32(), rect.Size.ToWin32());

        /// <summary>
        /// Creates a Plugin API rectangle from Win32 (GDI+).
        /// </summary>
        public static Plugin.Rectangle ToPlugin(Rectangle rect)
            => new(rect.X, rect.Y, rect.Width, rect.Height);
    }
}
