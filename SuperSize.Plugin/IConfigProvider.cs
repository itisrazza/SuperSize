using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize.Plugin
{
    /// <summary>
    /// Configuration provider interface. SuperSize implements this interface for saving and loading data.
    /// </summary>
    public interface IConfigProvider
    {
        /// <summary>
        /// Retrieves the currently saved configuration data.
        /// </summary>
        /// <returns>Retrieved configuration object.</returns>
        Config.Object GetConfig();

        /// <summary>
        /// Overwrites the currently saved configuration data.
        /// </summary>
        /// <param name="config">Configuration object to save.</param>
        void SaveConfig(Config.Object config);
    }
}
