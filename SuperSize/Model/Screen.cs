using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealScreen = System.Windows.Forms.Screen;

namespace SuperSize.Model
{
    public class Screen
    {
        /// <summary>
        /// The screen's location and size.
        /// </summary>
        public Rectangle Bounds { get; init; }

        /// <summary>
        /// The screen's usable work area.
        /// </summary>
        public Rectangle WorkingArea { get; init; }

        /// <summary>
        /// The real underlying screen from Windows.
        /// </summary>
        public RealScreen? RealScreen { get; init; }

        /// <summary>
        /// Whether this is a primary display.
        /// </summary>
        public bool Primary { get; init; }

        private Screen() { }

        /// <summary>
        /// Creates a dummy screen for testing.
        /// </summary>
        /// <param name="bounds">The size of the screen.</param>
        /// <param name="workingArea">The screen's working area.</param>
        /// <param name="primary">Whether this screen is the primary screen.</param>
        /// <returns>A screen object.</returns>
        public static Screen DummyScreen(Rectangle bounds, Rectangle workingArea, bool primary)
            => new()
            {
                Bounds = bounds,
                WorkingArea = workingArea,
                Primary = primary
            };

        /// <summary>
        /// Creates a new screen.
        /// </summary>
        /// <param name="screen">The screen to base on.</param>
        /// <returns></returns>
        public static Screen FromScreen(RealScreen screen)
            => new()
            {
                Bounds = screen.Bounds,
                WorkingArea = screen.WorkingArea,
                Primary = screen.Primary,
                RealScreen = screen
            };

        /// <summary>
        /// Gets all the screens on the system.
        /// </summary>
        /// <returns>An array with all the attached screens.</returns>
        public static Screen[] GetAllScreens()
            => RealScreen.AllScreens.Select(screen => FromScreen(screen)).ToArray();
    }
}
