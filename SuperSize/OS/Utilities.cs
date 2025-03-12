using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using Windows.Win32;
using Windows.Win32.UI.WindowsAndMessaging;
using Windows.Win32.Foundation;
using SuperSize.Model;

namespace SuperSize.OS
{
    public static class Utilities
    {
        public static List<(Window Window, string Title)> GetOpenWindows()
        {
            var list = new List<(Window Window, string Title)>();
            var shellWindow = PInvoke.GetShellWindow();

            PInvoke.EnumWindows(delegate (HWND hWnd, LPARAM lparam)
            {
                // ignore the shell window and hidden windows
                if (hWnd == shellWindow) return true;
                if (!PInvoke.IsWindowVisible(hWnd)) return true;

                // get window title
                var textLength = PInvoke.GetWindowTextLength(hWnd);
                if (textLength == 0) return true;
                var text = new char[textLength];
                PInvoke.GetWindowText(hWnd, text.AsSpan());

                // add to dict
                list.Add((new Window(hWnd), new string(text)));
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
