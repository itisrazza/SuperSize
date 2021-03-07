using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize
{
    public class Config
    {

        public Color ScreenBorderColor = rgb(45, 125, 154);
        public Color ScreenFillColor = rgb(0, 0, 255);
        public Color PrimaryScreenFillColor = rgb(0, 120, 215);
        public Color ScreenTextColor = Color.White;
        public string ScreenTextFontFamily = "Segoe UI";

        private static Color rgb(byte r, byte g, byte b) => Color.FromArgb(r, g, b);
    }
}
