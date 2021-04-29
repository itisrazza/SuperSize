using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    public abstract class SizingLogic
    {
        /// <summary>
        /// Whether this logic can be configured.
        /// </summary>
        public bool HasConfig => DoConfig != null;

        /// <summary>
        /// The action to run when the "Configure..." button is clicked.
        /// </summary>
        public Action? DoConfig { get; }
    }
}
