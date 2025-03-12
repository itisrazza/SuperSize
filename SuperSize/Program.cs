using SuperSize.Model;
using SuperSize.OS;
using SuperSize.Service;
using SuperSize.UI;
using SuperSize.UI.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            // app config
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // preflight stuff
            ValidateDirectoryStructure();

            // start the application
            ChangeHotkey(GetGlobalKeyboardShortcut());
            Application.Run(new NotifyIconForm());
        }

        public static void Exit()
        {
            _keyboardHook?.Dispose();
            Application.Exit();
        }

        public static string AppDataDirectory { get; } = Path.Join(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SuperSize");

        public static void ValidateDirectoryStructure()
        {
            CreateDirectoryIfNotExists(AppDataDirectory);
        }

        private static void CreateDirectoryIfNotExists(string path)
        {
            if (Directory.Exists(path)) return;
            Directory.CreateDirectory(path);
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
                SuperSizeWindow(window);
            };
            _keyboardHook.RegisterHotKey(shortcut.Modifier, shortcut.Key);
        }

        public static void SuperSizeWindow(Window window)
        {
            SizeService.SizeWindow(window);
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
