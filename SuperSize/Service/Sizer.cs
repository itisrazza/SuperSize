using SuperSize.Model;
using SuperSize.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Service
{
    public static class Sizer
    {

        private static Dictionary<string, Func<SizingLogic>> _builtInScripts = new()
        {
            { "Fill out completely", () => new Scripts.FillOutCompletely() },
        };

        public static ICollection<string> KnownBuiltInScripts { get; } = _builtInScripts.Keys;

        public static SizingLogic SelectedLogic()
        {
            var settings = Properties.Settings.Default;
            return settings.UseCustomScript
                ? PythonSizingLogic.FromSource(settings.Script)
                : _builtInScripts[settings.BuiltinScript]();
        }

        public static void SizeWindow(IntPtr window) => SizeWindow(window, SelectedLogic());

        public static void SizeWindow(IntPtr window, SizingLogic logic)
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
