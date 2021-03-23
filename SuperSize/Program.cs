using SuperSize.Model;
using SuperSize.OS;
using SuperSize.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // start the application
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChangeHotkey(GetGlobalKeyboardShortcut());
            Application.Run(new Forms.NotifyIconForm());
        }

        public static void Exit()
        {
            _keyboardHook?.Dispose();
            Application.Exit();
        }

        private static KeyboardHook? _keyboardHook = new();

        public static void ChangeHotkey(KeyboardShortcut shortcut)
        {
            _keyboardHook?.Dispose();
            if (shortcut.IsInvalid)
            {
                _keyboardHook = null;
                return;
            }

            _keyboardHook = new();
            _keyboardHook.KeyPressed += (_, _) =>
            {
                var window = Window.GetForegroundWindow();
                SuperSizeWindow(window.Handle);
            };
            _keyboardHook.RegisterHotKey(shortcut.Modifier, shortcut.Key);
        }

        public static void SuperSizeWindow(IntPtr window)
        {
            Sizer.SizeWindow(window);
        }

        public static KeyboardShortcut GetGlobalKeyboardShortcut()
            => new()
            {
                Modifier = (KeyboardShortcut.ModifierKeys)Properties.Settings.Default.ShortcutModifier,
                Key = (Keys)Properties.Settings.Default.ShortcutKey
            };

        public static string Version
        {
            get
            {
                var execAssembly = Assembly.GetExecutingAssembly();
                var fileVersionInfo = FileVersionInfo.GetVersionInfo(execAssembly.Location);
                return fileVersionInfo.ProductVersion ?? "TESTVER";
            }
        }
    }
}
