using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace SuperSize.OS
{
    public static class Utilities
    {
        public static List<(IntPtr Handle, string Title)> GetOpenWindows()
        {
            var list = new List<(IntPtr Handle, string Title)>();
            var shellWindow = NativeImports.GetShellWindow();
            NativeImports.EnumWindows(delegate (IntPtr hWnd, int lparam)
            {
                // ignore the shell window and hidden windows
                if (hWnd == shellWindow) return true;
                if (!NativeImports.IsWindowVisible(hWnd)) return true;

                // get window title
                var strLength = NativeImports.GetWindowTextLength(hWnd);
                var strBuilder = new StringBuilder(strLength);
                NativeImports.GetWindowText(hWnd, strBuilder, strLength + 1);

                // ignore it if the title is empty
                if (strBuilder.ToString() == string.Empty) return true;

                // add to dict
                list.Add((hWnd, strBuilder.ToString()));
                return true;
            }, 0);

            return list;
        }

        public static Rectangle GetAllScreenBounds()
        {
            var top = 0;
            var right = 0;
            var bottom = 0;
            var left = 0;
            foreach (var screen in Screen.AllScreens)
            {
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
