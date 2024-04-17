using SuperSize.Model;
using SuperSize.OS;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void SizeWindow(IntPtr window)
        {
            var logic = SelectedLogic;
            if (logic == null) return; 
            SizeWindow(window, logic);
        }

        public static void SizeWindow(IntPtr window, Logic logic)
        {
            NativeImports.SetForegroundWindow(window);
            NativeImports.ShowWindowAsync(window, nCmdShow: 1 /* regular */);

            var calculateSize = logic.Calculate();
            NativeImports.SetWindowPos(
                window,
                NativeImports.HWnd.Top,
                calculateSize.X,
                calculateSize.Y,
                calculateSize.Width,
                calculateSize.Height,
                uFlags: 0);
        }
    }
}
