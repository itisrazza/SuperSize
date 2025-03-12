using SuperSize.Model;
using SuperSize.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;

namespace SuperSize.Service
{
    /// <summary>
    /// Service class for resizing the windows using the current logic and configuration.
    /// </summary>
    public static class SizeService
    {
        private static HashSet<Logic> _knownLogic = new() { 
            new CoreLogic.ExpandFromCentre(),
            new CoreLogic.UseAllScreen(),
            new CoreLogic.PythonScript(),
        };

        private static Dictionary<string, Logic> _lookUpTable = new(_knownLogic.Select((logic) => new KeyValuePair<string, Logic>(logic.GetType().FullName!, logic)));

        public static ICollection<Logic> KnownLogic => _knownLogic;

        public static Logic? SelectedLogic
        {
            get
            {
                var settings = Properties.Settings.Default;
                return _lookUpTable.GetValueOrDefault(settings.LogicClass, new CoreLogic.UseAllScreen());
            }

            set
            {
                var settings = Properties.Settings.Default;
                settings.LogicClass = value?.GetType().FullName;
                settings.Save();
            }
        }

        public static void SizeWindow(Window window)
        {
            var logic = SelectedLogic;
            if (logic == null) return;
            SizeWindow(window, logic);
        }

        public static void SizeWindow(Window window, Logic logic)
        {
            if (!CanResize(window)) return;

            PInvoke.SetForegroundWindow(window.Handle);
            PInvoke.ShowWindowAsync(window.Handle, SHOW_WINDOW_CMD.SW_NORMAL);

            var calculateSize = logic.Calculate();
            PInvoke.SetWindowPos(
                window.Handle,
                HWND.HWND_TOP,
                calculateSize.X,
                calculateSize.Y,
                calculateSize.Width,
                calculateSize.Height,
                uFlags: 0);
        }

        private static bool CanResize(Window window)
        {
            return true;
        }
    }
}
