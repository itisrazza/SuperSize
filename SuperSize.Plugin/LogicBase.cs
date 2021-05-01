using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSize.Plugin
{
    public abstract class LogicBase
    {
        /// <summary>
        /// The name of the logic available seen by the user.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Whether this logic can be configured.
        /// </summary>
        public virtual bool HasConfig { get; } = false;

        /// <summary>
        /// The default configuration object when the logic is selected.
        /// </summary>
        public virtual Config.Object DefaultConfig { get; } = new();

        /// <summary>
        /// The action to run when the "Configure..." button is clicked.
        /// </summary>
        public virtual void DoConfig(IConfigProvider configProvider)
        {
            // by default configuration is disabled
        }

        /// <summary>
        /// The function to run when super-sizing a window.
        /// </summary>
        /// <param name="screens">Rectangles showing the location of the screens.</param>
        /// <param name="config">The logic configuration, if any.</param>
        /// <returns>Rectangle the window is going to be resized to.</returns>
        public abstract Rectangle DoSize(Screen[] screens, Config.Object? config = null);

        public override string ToString()
        {
            return Name;
        }
    }
}
