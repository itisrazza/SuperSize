using System.Drawing;
using System.Windows.Forms;

namespace SuperSize.Scripting.Python;

public static class PythonHelpers
{
    public static Screen[] Screens()
    {
        return Screen.AllScreens;
    }

    public static Rectangle Rectangle(int x, int y, int width, int height)
    {
        return new Rectangle(x, y, width, height);
    }

    public static Point Point(int x, int y)
    {
        return new Point(x, y);
    }

    public static Size Size(int width, int height)
    {
        return new Size(width, height);
    }
}
