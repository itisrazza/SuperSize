﻿using SuperSize.PluginBase;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.CoreLogic
{
    [Guid("E9CAE8C8-02F8-4969-ABCB-28172516A3A4")]
    public class UseAllScreen : Logic
    {
        public override string DisplayName { get; } = "Use all the screen real estate";

        public override Task<Rectangle> CalculateWindowSize(Screen[] screens, Settings config)
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
            return Task.FromResult(Rectangle.FromLTRB(left, top, right, bottom));
        }

        public override void ShowSettings(Settings settings)
        {
            DisplayNoSettingsMessage();
        }
    }
}
