using SuperSize.Model;
using SuperSize.Service;
using System;
using System.Diagnostics;
using System.Drawing;
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
            if (logic == null)
            {
                return Rectangle.Empty;
            }

            var settings = SettingsService.GetSettings(logic);
            var result = logic.CalculateWindowSize(settings).Result;
            
            if (result.TryGetRectangle(out var rectangle))
            {
                return rectangle;
            }

            if (result.HasException)
            {
                throw new Exception("Logic returned an exception", result.Exception!);
            }

            Debug.Print($"Logic returned no result: {result.NoResultMessage}");
            return Rectangle.Empty;
        }
    }
}
