using SuperSize.PluginBase;
using SuperSize.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperSize
{
    public static class Extensions
    {

        public static void Deconstruct(this Size size, out int width, out int height)
        {
            width = size.Width;
            height = size.Height;
        }

        public static void Deconstruct(this Rectangle rectangle, out int x, out int y, out int width, out int height)
        {
            x = rectangle.X;
            y = rectangle.Y;
            width = rectangle.Width;
            height = rectangle.Height;
        }

        public static Rectangle Calculate(this Logic logic)
        {
            if (logic == null) logic = PluginService.NullLogic;
            return logic.CalculateWindowSize(Screen.AllScreens, SettingsService.GetSettings(logic)).Result;
        }

        public static string DllPath(this Plugin plugin)
            => plugin.GetType().Assembly.Location;
    }
}
