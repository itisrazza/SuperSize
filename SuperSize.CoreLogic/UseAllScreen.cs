using SuperSize.Plugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.CoreLogic
{
    public class UseAllScreen : LogicBase
    {
        public override string Name { get; } = "Use all the screen real estate";

        public override Rectangle DoSize(Screen[] screens, SuperSize.Plugin.Config.Object config = null)
        {
            var left = int.MaxValue;
            var top = int.MaxValue;
            var right = int.MinValue;
            var bottom = int.MinValue;
            foreach (var screen in screens)
            {
                var bounds = screen.Bounds;
                left = Math.Min(left, bounds.Left);
                top = Math.Min(top, bounds.Top);
                right = Math.Max(right, bounds.Right);
                bottom = Math.Max(bottom, bounds.Bottom);
            }
            return Rectangle.FromLTRB(left, top, right, bottom);
        }
    }
}
