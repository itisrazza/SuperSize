using SuperSize.Model;
using SuperSize.Service;
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

            return logic.CalculateWindowSize(SettingsService.GetSettings(logic)).Result;
        }
    }
}
