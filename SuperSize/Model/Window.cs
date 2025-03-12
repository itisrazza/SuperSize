using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace SuperSize.Model
{
    /// <summary>
    /// Wrapper class for native windows.
    /// </summary>
    public class Window : IWin32Window
    {
        internal HWND Handle { get; }

        nint IWin32Window.Handle
        {
            get
            {
                unsafe
                {
                    return (nint)Handle.Value;
                }
            }
        }

        internal Window(HWND hWnd)
        {
            Handle = hWnd;
        }

        public string Text
        {
            get
            {
                var length = PInvoke.GetWindowTextLength(Handle);
                var str = new char[length + 1];
                PInvoke.GetWindowText(Handle, str.AsSpan());
                return new string(str);
            }
        }

        public bool Visible => PInvoke.IsWindowVisible(Handle);

        public static Window ShellWindow => new(PInvoke.GetShellWindow());

        public static IEnumerable<Window> Windows
        {
            get
            {
                return new List<Window>();
            }
        }


        public static Window GetForegroundWindow() => new Window(PInvoke.GetForegroundWindow());

        public void BringToTop() => PInvoke.BringWindowToTop(Handle);

        internal void Show(SHOW_WINDOW_CMD nCmdShow) => PInvoke.ShowWindowAsync(Handle, nCmdShow);

        public void Focus() => PInvoke.SetForegroundWindow(Handle);

        public void SetPosition(Rectangle rectangle) => SetPosition(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);

        private void SetPosition(int x, int y, int width, int height)
        {
            var hresult = PInvoke.SetWindowPos(
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
