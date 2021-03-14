using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

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

                // add to dict
                list.Add((hWnd, strBuilder.ToString()));
                return true;
            }, 0);

            return list;
        }
    }
}
