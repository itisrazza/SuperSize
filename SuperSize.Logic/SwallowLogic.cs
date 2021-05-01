using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicBase = SuperSize.Plugin.Logic;

namespace SuperSize.Logic
{
    public class SwallowLogic : LogicBase
    {
        public override string Name { get; } = "Extend to all screens.";

        public override Rectangle DoSize(Screen[] screens, SuperSize.Plugin.Config.Object config = null)
        {
            var left = int.MaxValue;
            var top = int.MaxValue;
            var right = int.MinValue;
            var bottom = int.MinValue;
            foreach (var screen in screens)
            {
                left = Math.Min(left, screen.Bounds.Left);
                top = Math.Min(top, screen.Bounds.Top);
                right = Math.Max(right, screen.Bounds.Right);
                bottom = Math.Max(bottom, screen.Bounds.Bottom);
            }
            return Rectangle.FromLTRB(left, top, right, bottom);
        }
    }
}
