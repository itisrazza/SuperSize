using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.OS
{
    /// <summary>
    /// Definitions for Win32 API calls. Don't use these methods directly.
    /// </summary>
    internal static class NativeImports
    {
        /// <see cref="KeyboardHook.RegisterHotKey(Model.KeyboardShortcut.ModifierKeys, System.Windows.Forms.Keys)"/>
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        /// <see cref="KeyboardHook.Dispose"/>
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

        /// <see cref="Model.Window.Windows"/>
        [DllImport("USER32.DLL")]
        public static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        /// <see cref="Model.Window.Text"/>
        [DllImport("USER32.DLL")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <see cref="Model.Window.Text"/>
        [DllImport("USER32.DLL")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        /// <see cref="Model.Window.Visible"/>
        [DllImport("USER32.DLL")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        /// <see cref="Model.Window.ShellWindow"/>
        [DllImport("USER32.DLL")]
        public static extern IntPtr GetShellWindow();

        /// <see cref="Model.Window.BringToTop"/>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        /// <see cref="Model.Window.Show(int)"/>
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        /// <see cref="Model.Window.Focus"/>
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <see cref="Model.Window.GetForeground"/>
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        /// <see cref="Model.Window.SetPosition(int, int, int, int)"/>
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
            
        public static class HWnd
        {
            public static IntPtr Bottom { get; } = new IntPtr(1);
            public static IntPtr NoTopMost { get; } = new IntPtr(-2);
            public static IntPtr Top { get; } = new IntPtr(0);
            public static IntPtr TopMost { get; } = new IntPtr(-1);
        }
    }
}
