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
        public static ICollection<string> KnownBuiltInScripts { get; } = new List<string>();

        private static HashSet<Logic>? _knownLogic = null;
        public static ICollection<Logic> KnownLogic
        {
            get
            {
                if (_knownLogic == null)
                {
                    _knownLogic = PluginService.Plugins
                        .SelectMany((plugin) => plugin.AvailableLogic)
                        .ToHashSet();
                }
                return _knownLogic;
            }
        }

        public static Logic SelectedLogic()
        {
            var settings = Properties.Settings.Default;
            throw new NotImplementedException("Undergoing plugin rewrite.");
        }

        public static void SizeWindow(IntPtr window) => SizeWindow(window, SelectedLogic());

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
