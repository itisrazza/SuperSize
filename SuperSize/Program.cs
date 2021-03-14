using SuperSize.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.NotifyIconForm());
        }

        public static KeyboardShortcut GetGlobalKeyboardShortcut()
            => new()
            {
                Modifier = (KeyboardShortcut.ModifierKeys)Properties.Settings.Default.ShortcutModifier,
                Key = (Keys)Properties.Settings.Default.ShortcutKey
            };
    }
}
