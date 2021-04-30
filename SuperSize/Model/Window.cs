using SuperSize.OS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SuperSize.OS.NativeImports;

namespace SuperSize.Model
{
    /// <summary>
    /// Wrapper class for native windows.
    /// </summary>
    public class Window : IWin32Window
    {
        public IntPtr Handle { get; }

        public Window(IntPtr hWnd)
        {
            Handle = hWnd;
        }

        public string Text
        {
            get
            {
                var length = GetWindowTextLength(Handle);
                var sb = new StringBuilder(length);
                GetWindowText(Handle, sb, length + 1);
                // TODO: check for Win32 errors (0 could either mean, no title, or error)
                return sb.ToString();
            }
        }

        public bool Visible => IsWindowVisible(Handle);

        public static Window ShellWindow => new(GetShellWindow());

        public static IEnumerable<Window> Windows
        {
            get
            {
                return new List<Window>();
            }
        }

        public static Window GetForegroundWindow() => new Window(NativeImports.GetForegroundWindow());

        public void BringToTop() => BringWindowToTop(Handle);

        public void Show(int nCmdShow) => ShowWindowAsync(Handle, nCmdShow);

        public void Focus() => SetForegroundWindow(Handle);
        
        public void SetPosition(Rectangle rectangle) => SetPosition(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);

        private void SetPosition(int x, int y, int width, int height)
        {
            var hresult = SetWindowPos(
                Handle, 
                hWndInsertAfter: new(0),    // move the window to the top
                x, y, width, height, 0);
            if (!hresult)
            {
                Marshal.ThrowExceptionForHR(Marshal.GetLastWin32Error());
            }
        }
    }
}
