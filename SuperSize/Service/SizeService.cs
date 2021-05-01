using SuperSize.Model;
using SuperSize.OS;
using SuperSize.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Service
{
    /// <summary>
    /// Service class for resizing the windows using the current logic and configuration.
    /// </summary>
    public static class SizeService
    {
        private static Dictionary<string, LogicBase> _lookUpTable = new();
        private static HashSet<LogicBase>? _knownLogic = null;
        public static ICollection<LogicBase> KnownLogic
        {
            get
            {
                if (_knownLogic == null)
                {
                    _knownLogic = PluginService.Plugins
                        .SelectMany((plugin) => plugin.AvailableLogic)
                        .ToHashSet();
                    _lookUpTable = _knownLogic
                        .ToDictionary((plugin) => plugin.GetType().FullName ?? plugin.GetType().Name);
                }
                return _knownLogic;
            }
        }

        public static LogicBase? SelectedLogic
        {
            get
            {
                var settings = Properties.Settings.Default;
                return _lookUpTable.GetValueOrDefault(settings.LogicClass, PluginService.NullLogic);
            }

            set
            {
                var settings = Properties.Settings.Default;
                settings.LogicClass = value?.GetType().FullName;
                settings.Save();
            }
        }

        public static void SizeWindow(IntPtr window) => SizeWindow(window, SelectedLogic);

        public static void SizeWindow(IntPtr window, LogicBase logic)
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
