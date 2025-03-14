using SuperSize.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.CoreLogic;

[Guid("C5E84694-AEFD-4FEB-9FCC-765CA37B9A2C")]
public class ExpandFromCentre : Logic
{
    public override string DisplayName { get; } = "Expand from centre";

    public override Task<LogicResult> CalculateWindowSize(Settings config)
    {
        var primary = Screen.PrimaryScreen.Bounds;
        var centre = new Point(primary.Left + primary.Width / 2, primary.Height / 2);

        var allBounds = OS.Utilities.GetAllScreenBounds();
        var targetTop = Math.Abs(centre.Y - allBounds.Top);
        var targetRight = Math.Abs(centre.X - allBounds.Right);
        var targetBottom = Math.Abs(centre.Y - allBounds.Bottom);
        var targetLeft = Math.Abs(centre.X - allBounds.Left);

        var targetWidth = Math.Min(targetLeft, targetRight);
        var targetHeight = Math.Min(targetTop, targetBottom);

        return Task.FromResult(LogicResult.OK(
            Rectangle.FromLTRB(
                centre.X - targetWidth,
                centre.Y - targetHeight,
                2 * targetWidth,
                2 * targetHeight
        )));
    }
}
