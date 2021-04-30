using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public abstract class Logic
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
        /// <returns></returns>
        public abstract Rectangle DoSize(Rectangle[] screens, Config.Object? config = null);
    }
}
