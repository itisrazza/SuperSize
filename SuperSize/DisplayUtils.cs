using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperSize
{
    public class DisplayUtils
    {
        public static Rectangle GetAllScreenBounds()
        {
            var top = 0;
            var right = 0;
            var bottom = 0;
            var left = 0;
            foreach (var screen in Screen.AllScreens) {
                var (x, y, width, height) = screen.Bounds;
                if (x < left) left = x;
                if (y < top) top = y;
                if (x + width > right) right = x + width;
                if (y + height > bottom) bottom = y + height;
            }

            return new(left, top, right - left, bottom - top);
        }
    }
}
